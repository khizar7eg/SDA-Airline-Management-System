using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace commerced
{
    class xidhiidhiye 
        
    {
        // kk
        SqlConnection con = new SqlConnection(@"Data Source=RIDWAN\SABOWANAAG;Initial Catalog=competition;Integrated Security=True");

        public void diwaangaliemployee(employee employeeobj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO employee (Name, address, Telephone, salary, job, gender, email, Nationality, vilage, Datejoined) VALUES(@Name, @address, @Telephone, @salary, @job, @gender, @email, @Nationality, @vilage, @Datejoined)", con);
            cmd.Parameters.AddWithValue("@Name", employeeobj.magaca);
            cmd.Parameters.AddWithValue("@address", employeeobj.ciwanka);
            cmd.Parameters.AddWithValue("@Telephone", employeeobj.mobilka);
            cmd.Parameters.AddWithValue("@salary", employeeobj.mushaharka);
            cmd.Parameters.AddWithValue("@job", employeeobj.shaqada);
            cmd.Parameters.AddWithValue("@gender", employeeobj.nooca);
            cmd.Parameters.AddWithValue("@email", employeeobj.ciwinterta);
            cmd.Parameters.AddWithValue("@Nationality", employeeobj.dalkashaqaalaha);
            cmd.Parameters.AddWithValue("@vilage", employeeobj.xaafadashaqaalaha);
            cmd.Parameters.AddWithValue("@Datejoined", employeeobj.Taariikhda);
            cmd.ExecuteNonQuery();

            con.Close();
        }


        // Load all data
        public DataTable LoadData(string table)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open(); 
            }
            string query = "SELECT * FROM " + table;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            return dt;
            //con.Close();
        }


        //this following code is delete the database.
        public void masax(int employeeid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            } 
            SqlCommand cmd = new SqlCommand("DELETE FROM  employee WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", employeeid);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //end code of delete.
        public void dibubadal(int employeeid, employee updateEmployee)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("UPDATE employee SET Name = @Name, address = @address, Telephone = @Telephone, salary = @salary, job = @job, gender = @gender, email = @email, Nationality = @Nationality, vilage = @vilage, Datejoined = @Datejoined WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@Name", updateEmployee.magaca);
            cmd.Parameters.AddWithValue("@address", updateEmployee.ciwanka);
            cmd.Parameters.AddWithValue("@Telephone", updateEmployee.mobilka);
            cmd.Parameters.AddWithValue("@salary", updateEmployee.mushaharka);
            cmd.Parameters.AddWithValue("@job", updateEmployee.shaqada);
            cmd.Parameters.AddWithValue("@gender", updateEmployee.nooca);
            cmd.Parameters.AddWithValue("@email", updateEmployee.ciwinterta);
            cmd.Parameters.AddWithValue("@Nationality", updateEmployee.dalkashaqaalaha);
            cmd.Parameters.AddWithValue("@vilage", updateEmployee.xaafadashaqaalaha);
            cmd.Parameters.AddWithValue("@Datejoined", updateEmployee.Taariikhda);
            cmd.Parameters.AddWithValue("@ID", employeeid);
                cmd.ExecuteNonQuery();

        }

       
        //Bilowga updateka

        
        //end of update code
        public DataTable read()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from employee", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

       

        


       //kkk
        //halkan waxa kabilaabmaya codeka iriportka
        public void diwangaliaiport(Hairport myobj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" INSERT INTO [myairport] VALUES(@Airportname, @Airportlocation, @Noemployee, @Noairplanes, @Trafic, @airportmanager, @year, @Datecreated)", con);
            cmd.Parameters.AddWithValue("@AirportName", myobj.magacairiportka);
            cmd.Parameters.AddWithValue("@Airportlocation", myobj.goobtairiportka);
            cmd.Parameters.AddWithValue("@Noemployee", myobj.tiradashaqaalaha);
            cmd.Parameters.AddWithValue("@NoAirplanes", myobj.tiradadiyaaradaha);
            cmd.Parameters.AddWithValue("@Trafic", myobj.tiradatraffee);
            cmd.Parameters.AddWithValue("@Airportmanager", myobj.mamulkairiportka);
            cmd.Parameters.AddWithValue("@year", myobj.sanadkalajoogo);
            cmd.Parameters.AddWithValue("@Datecreated", myobj.Tladhisay);
            cmd.ExecuteNonQuery();
            con.Close();
        }



        public void deletegareeiriboodhka(int airportid)
        {
            //kkk
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("DELETE FROM  myairport WHERE ID =@ID", con);
            cmd.Parameters.AddWithValue("@ID", airportid);
            cmd.ExecuteNonQuery();
           
          
            //kk
        }
   //this code is the update of international airport
       public void changedata(int cadayntairiporka, Hairport updateairport)

        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("UPDATE myairport SET Airportname = @Airportname, Airportlocation = @Airportlocation, Noemployee = @Noemployee, Noairplanes = @Noairplanes, Trafic = @Trafic, airportmanager = @airportmanager, year = @year, Datecreated = @Datecreated WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@Airportname", updateairport.magacairiportka);
            cmd.Parameters.AddWithValue("@Airportlocation", updateairport.goobtairiportka);
            cmd.Parameters.AddWithValue("@Noemployee", updateairport.tiradashaqaalaha);
            cmd.Parameters.AddWithValue("@Noairplanes", updateairport.tiradadiyaaradaha);
            cmd.Parameters.AddWithValue("@Trafic", updateairport.tiradatraffee);
            cmd.Parameters.AddWithValue("@airportmanager", updateairport.mamulkairiportka);
            cmd.Parameters.AddWithValue("@year", updateairport.sanadkalajoogo);
            cmd.Parameters.AddWithValue("@Datecreated", updateairport.Tladhisay);
            cmd.Parameters.AddWithValue("@ID", cadayntairiporka);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //end of code

       public void insertincome(myincome dakhliga )
       {
           con.Open();
           SqlCommand cmd = new SqlCommand(" INSERT INTO [egalincomes] VALUES(@Indescription, @Type, @DATE, @Amounts)", con);
           //cmd.Parameters.AddWithValue("@INno", dakhliga.incomenumber);
           cmd.Parameters.AddWithValue("@Indescription", dakhliga.incomedescriptionka);
           cmd.Parameters.AddWithValue("@Type", dakhliga.noocaproject);
           cmd.Parameters.AddWithValue("@DATE", dakhliga.datekaincomeka);
           cmd.Parameters.AddWithValue("@Amounts", dakhliga.xadigaincomekasoogalay);
           cmd.ExecuteNonQuery();
           con.Close();
       }
        //dhamaadka corde dakhligalinta
       public void updateincome(int INno, myincome updatedakhli)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand("UPDATE egalincomes SET  Indescription = @Indescription, Type = @Type, DATE = @DATE, Amounts = @Amounts WHERE INno = @INno", con);
           //cmd.Parameters.AddWithValue("@INno", updatedakhli);
           cmd.Parameters.AddWithValue("@Indescription", updatedakhli.incomedescriptionka);
           cmd.Parameters.AddWithValue("@Type", updatedakhli.noocaproject);
           cmd.Parameters.AddWithValue("@DATE", updatedakhli.datekaincomeka);
           cmd.Parameters.AddWithValue("@Amounts", updatedakhli.xadigaincomekasoogalay);
           cmd.Parameters.AddWithValue("@INno", INno);
           cmd.ExecuteNonQuery();
           con.Close();
       }
        //end of updating code of egalincome table
       public void khadkakasaar(int incomenumberka)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("DELETE FROM  egalincomes WHERE INno = @INno", con);
           cmd.Parameters.AddWithValue("@INno", incomenumberka);
           cmd.ExecuteNonQuery();
           con.Close();

       }
       //end of income codes.
       public void galikharashadkayaga(workingexpenses expplace)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand(" INSERT INTO [workingcapitalexpense] VALUES(@EXpensetype, @DATE, @AMOUNT)", con);
          cmd.Parameters.AddWithValue("@EXpensetype", expplace.expenstypekalagushaqeeyay);
           cmd.Parameters.AddWithValue("@DATE", expplace.taariikhdakharashlagushaqeeyo);
           cmd.Parameters.AddWithValue("@AMOUNT", expplace.amountigakhlagushqeeyay);
           cmd.ExecuteNonQuery();
           con.Close();
       }
        //
       public void updategareekharashaadka(int KAAF, workingexpenses kitta)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand(" UPDATE workingcapitalexpense SET EXpensetype = @EXpensetype, DATE = @DATE, AMOUNT = @AMOUNT where EXPNO = @EXPNO", con);
           cmd.Parameters.AddWithValue("@EXpensetype", kitta.expenstypekalagushaqeeyay);
           cmd.Parameters.AddWithValue("@DATE", kitta.taariikhdakharashlagushaqeeyo);
           cmd.Parameters.AddWithValue("@AMOUNT", kitta.amountigakhlagushqeeyay);
           cmd.Parameters.AddWithValue("@EXPNO", KAAF);
           cmd.ExecuteNonQuery();
           con.Close();
       }
       public void masaxkharashka(int katanga, workingexpenses kill)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand(" DELETE FROM workingcapitalexpense WHERE EXPNO =@EXPNO", con);
           cmd.Parameters.AddWithValue("@EXPNO", katanga);
           cmd.ExecuteNonQuery();
           con.Close();
       }

       public void givethesalary(salaryexpenses lctuhelay)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand(" INSERT INTO [employeesalaryexpense] (salaryforthemonth, year, employeename, Job_Title, Basicsalary, Hrs, Extra_money, Noleaves, salaryDate, Gross_salary, Net_salary) VALUES(@salaryforthemonth, @year, @employeename, @Job_Title, @Basicsalary, @Hrs, @Extra_money, @Noleaves, @salaryDate, @Gross_salary, @Net_salary)", con);
           cmd.Parameters.AddWithValue("@salaryforthemonth", lctuhelay.bishashaqada);
           cmd.Parameters.AddWithValue("@year", lctuhelay.sanadkushaqeeyay);
           cmd.Parameters.AddWithValue("@employeename", lctuhelay.magacashaqaalaha);
           cmd.Parameters.AddWithValue("@job_Title", lctuhelay.Takhasuskiisashaqo);
           cmd.Parameters.AddWithValue("@Basicsalary", lctuhelay.lacagtuqaato);
           cmd.Parameters.AddWithValue("@Hrs", lctuhelay.Hraga);
           cmd.Parameters.AddWithValue("@Extra_money", lctuhelay.specialalowensiga);
           cmd.Parameters.AddWithValue("@Noleaves", lctuhelay.intuqaaibahaa);
           cmd.Parameters.AddWithValue("@salaryDate", lctuhelay.xiligulacagtahelay);
           cmd.Parameters.AddWithValue("@Gross_salary", lctuhelay.allgidi);
           cmd.Parameters.AddWithValue("@Net_salary", lctuhelay.Netsalariga);
           cmd.ExecuteNonQuery();

       }
    //here is the beging of arrival peaple table

       public void registerarrivals(comingpeaple savecommingpeaple)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand(" INSERT INTO [Arivalpeaple] VALUES(@Name, @Address, @Nationality, @host_country, @Purpose, @Passport_Type, @passport_No, @Taxamounts, @checking, @Age, @Gender, @Date)", con);
           cmd.Parameters.AddWithValue("@Name", savecommingpeaple.arrivalnameka);
           cmd.Parameters.AddWithValue("@Address", savecommingpeaple.addreskiisa);
           cmd.Parameters.AddWithValue("@Nationality", savecommingpeaple.hoygiisa);
           cmd.Parameters.AddWithValue("@host_country", savecommingpeaple.martigaliye);
           cmd.Parameters.AddWithValue("@Purpose", savecommingpeaple.ujeedaduuyimi);
           cmd.Parameters.AddWithValue("@Passport_Type", savecommingpeaple.noocapasportkiisa);
           cmd.Parameters.AddWithValue("@passport_No", savecommingpeaple.pasportnumberka);
           cmd.Parameters.AddWithValue("@Taxamounts", savecommingpeaple.cashuurtiisa);
           cmd.Parameters.AddWithValue("@checking", savecommingpeaple.inlaeegay);
           cmd.Parameters.AddWithValue("@Age", savecommingpeaple.cimrigiisa);
           cmd.Parameters.AddWithValue("@Gender", savecommingpeaple.labordhedig);
           cmd.Parameters.AddWithValue("@Date", savecommingpeaple.xiliguyimi);
           cmd.ExecuteNonQuery();
            
           con.Close();
       }
       public void updatearrivals(int Ar_ID, comingpeaple updatecommingpeaple)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand("UPDATE Arivalpeaple SET Name = @Name, Address = @Address, Nationality = @Nationality, host_country = @host_country, purpose = @Purpose, passport_Type = @Passport_Type, passport_No = @passport_No, Taxamounts = @Taxamounts, checking = @checking, Age = @Age, Gender = @Gender, Date = @Date WHERE Ar_ID = @Ar_ID", con);
           cmd.Parameters.AddWithValue("@Name", updatecommingpeaple.arrivalnameka);
           cmd.Parameters.AddWithValue("@Address", updatecommingpeaple.addreskiisa);
           cmd.Parameters.AddWithValue("@Nationality", updatecommingpeaple.hoygiisa);
           cmd.Parameters.AddWithValue("@host_country", updatecommingpeaple.martigaliye);
           cmd.Parameters.AddWithValue("@Purpose", updatecommingpeaple.ujeedaduuyimi);
           cmd.Parameters.AddWithValue("@Passport_Type", updatecommingpeaple.noocapasportkiisa);
           cmd.Parameters.AddWithValue("@passport_No", updatecommingpeaple.pasportnumberka);
           cmd.Parameters.AddWithValue("@Taxamounts", updatecommingpeaple.cashuurtiisa);
           cmd.Parameters.AddWithValue("@checking", updatecommingpeaple.inlaeegay);
           cmd.Parameters.AddWithValue("@Age", updatecommingpeaple.cimrigiisa);
           cmd.Parameters.AddWithValue("@Gender", updatecommingpeaple.labordhedig);
           cmd.Parameters.AddWithValue("@Date", updatecommingpeaple.xiliguyimi);
           cmd.Parameters.AddWithValue("@Ar_ID", Ar_ID);
           cmd.ExecuteNonQuery();

           con.Close();
       }
       public void masaxarrivalpeaple(int bk)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("DELETE FROM  Arivalpeaple WHERE Ar_ID = @Ar_ID", con);
           cmd.Parameters.AddWithValue("@Ar_ID", bk);
           cmd.ExecuteNonQuery();
           con.Close();
       }
        //end of arrival table
       public void registeraduptures(outing saveoutgoingpeaple)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand(" INSERT INTO [Departure] VALUES(@Name, @Address, @Nationality, @To_country, @passport_Type, @passport_No, @Tax, @checking, @Age, @Gender, @Date)", con);
           cmd.Parameters.AddWithValue("@Name", saveoutgoingpeaple.magacatagaha);
           cmd.Parameters.AddWithValue("@Address", saveoutgoingpeaple.addreskatagaha);
           cmd.Parameters.AddWithValue("@Nationality", saveoutgoingpeaple.nationalitigatagaha);
           cmd.Parameters.AddWithValue("@To_country", saveoutgoingpeaple.tocountrigatagaha);
           cmd.Parameters.AddWithValue("@Passport_Type", saveoutgoingpeaple.pasporttypekatagaha);
           cmd.Parameters.AddWithValue("@Passport_No", saveoutgoingpeaple.passportnambarkatagaha);
           cmd.Parameters.AddWithValue("@Tax", saveoutgoingpeaple.cashuurtatagaha);
           cmd.Parameters.AddWithValue("@checking", saveoutgoingpeaple.checkingkatagaha);
           cmd.Parameters.AddWithValue("@Age", saveoutgoingpeaple.agekatagaha);
           cmd.Parameters.AddWithValue("@Gender", saveoutgoingpeaple.genderkatagaha);
           cmd.Parameters.AddWithValue("@Date", saveoutgoingpeaple.datekatagaha);
           cmd.ExecuteNonQuery();

           con.Close();
       }
       public void masaxdeparture(int departureid)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("DELETE FROM  Departure WHERE Dep_ID = @Dep_ID", con);
           cmd.Parameters.AddWithValue("@Dep_ID", departureid);
           cmd.ExecuteNonQuery();
           con.Close();
       }
        //
       public void updateaduptures(int Dep_ID, outing updateoutgoingpeaple)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand("UPDATE Departure SET Name = @Name, Address = @address,  Nationality = @Nationality, To_country = @To_country, passport_Type = @passport_Type, Tax = @Tax, checking = @checking, Age = @Age, Gender = @Gender, Date = @Date WHERE Dep_ID = @Dep_ID", con);
           cmd.Parameters.AddWithValue("@Name", updateoutgoingpeaple.magacatagaha);
           cmd.Parameters.AddWithValue("@Address", updateoutgoingpeaple.addreskatagaha);
           cmd.Parameters.AddWithValue("@Nationality", updateoutgoingpeaple.nationalitigatagaha);
           cmd.Parameters.AddWithValue("@To_country", updateoutgoingpeaple.tocountrigatagaha);
           cmd.Parameters.AddWithValue("@Passport_Type", updateoutgoingpeaple.pasporttypekatagaha);
           cmd.Parameters.AddWithValue("@Passport_No", updateoutgoingpeaple.passportnambarkatagaha);
           cmd.Parameters.AddWithValue("@Tax", updateoutgoingpeaple.cashuurtatagaha);
           cmd.Parameters.AddWithValue("@checking", updateoutgoingpeaple.checkingkatagaha);
           cmd.Parameters.AddWithValue("@Age", updateoutgoingpeaple.agekatagaha);
           cmd.Parameters.AddWithValue("@Gender", updateoutgoingpeaple.genderkatagaha);
           cmd.Parameters.AddWithValue("@Date", updateoutgoingpeaple.datekatagaha);
           cmd.Parameters.AddWithValue("@Dep_ID", Dep_ID);
           cmd.ExecuteNonQuery();

           con.Close();
       }
       public void registerabagaashka(exporting_materials savematerials)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand(" INSERT INTO [EXPORTS] VALUES(@materialName, @Owner, @Tax, @from_country, @To_country, @size, @weight, @Date)", con);
           cmd.Parameters.AddWithValue("@materialName", savematerials.magacabadeecada);
           cmd.Parameters.AddWithValue("@Owner", savematerials.shakhsigaleh);
           cmd.Parameters.AddWithValue("@Tax", savematerials.cashuurtabaddeecada);
           cmd.Parameters.AddWithValue("@from_country", savematerials.dalkaykadhoofaysobaddeecadu);
           cmd.Parameters.AddWithValue("@To_country", savematerials.dalkayudhoofaysobaddeecadu);
           cmd.Parameters.AddWithValue("@size", savematerials.baaxadabadeecada);
           cmd.Parameters.AddWithValue("@weight", savematerials.culayskabadeecada);
           cmd.Parameters.AddWithValue("@Date", savematerials.taariikhdabadeecada);
           cmd.ExecuteNonQuery();

           con.Close();
       }
        //
       public void updateabagaashka(int aydhiigabadeecad, exporting_materials savematerials)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand(" UPDATE EXPORTS SET material_Name = @material_Name, Owner = @Owner, Tax = @Tax, from_country = @from_country, To_country = @To_country, size = @size, weight = @weight, Date = @Date WHERE ID = @ID", con);
           cmd.Parameters.AddWithValue("@material_Name", savematerials.magacabadeecada);
           cmd.Parameters.AddWithValue("@Owner", savematerials.shakhsigaleh);
           cmd.Parameters.AddWithValue("@Tax", savematerials.cashuurtabaddeecada);
           cmd.Parameters.AddWithValue("@from_country", savematerials.dalkaykadhoofaysobaddeecadu);
           cmd.Parameters.AddWithValue("@To_country", savematerials.dalkayudhoofaysobaddeecadu);
           cmd.Parameters.AddWithValue("@size", savematerials.baaxadabadeecada);
           cmd.Parameters.AddWithValue("@weight", savematerials.culayskabadeecada);
           cmd.Parameters.AddWithValue("@Date", savematerials.taariikhdabadeecada);
           cmd.Parameters.AddWithValue("@ID", aydhiigabadeecad);
           cmd.ExecuteNonQuery();

           con.Close();
       }

       public void deletebagaashka(int aydhii)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand("DELETE FROM EXPORTS WHERE ID =@ID", con);
           cmd.Parameters.AddWithValue("@ID", aydhii);
           cmd.ExecuteNonQuery();
           con.Close();
       }



        
        //}dhamaad

        //internal void deletegareeairport(int id)
        //{
        //    throw new NotImplementedException();
        //}

       //internal void updateaduptures(outing mam)
       //{
       //    throw new NotImplementedException();
       //}

       //internal void dibubadal(int id, outing mam)
       //{
       //    throw new NotImplementedException();
       //}

       internal object updateaduptures(string p)
       {
           throw new NotImplementedException();
       }

       //internal void updateincome(int id, myincome resavedakhli)
       //{
       //    throw new NotImplementedException();
       //}

       internal void masaxkharashka(int EXPNO)
       {
           throw new NotImplementedException();
       }
    }
}
