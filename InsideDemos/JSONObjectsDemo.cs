using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace InsideDotNet.InsideDemos
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    internal class JsonObjectsDemo
    {
        public void ConvertJsonToObject()
        {
            string jsonData = "{\"DeptId\": 101, \"DepartmentName\": \"IT\"}";

            Department deptObj = JsonSerializer.Deserialize<Department>(jsonData);

            Console.WriteLine("Convert Json To Object");
            Console.WriteLine("Department Id: {0}", deptObj.DepartmentId);
            Console.WriteLine("Department Name: {0}", deptObj.DepartmentName);
            Console.WriteLine(Environment.NewLine);
        }

        public void ConvertJsonArrayToList()
        {
            string jsonArray = @"[
                                    {""DepartmentId"": 101, ""DepartmentName"": ""IT"" },
                                    {""DepartmentId"": 102, ""DepartmentName"": ""Accounts"" }
                                 ]";

            var deptList = JsonSerializer.Deserialize<IList<Department>>(jsonArray);

            Console.WriteLine("Convert Json Array To List");

            foreach (var dept in deptList)
            {
                Console.WriteLine("Department Id is: {0}", dept.DepartmentId);
                Console.WriteLine("Department Name is: {0}", dept.DepartmentName);
            }

            Console.WriteLine(Environment.NewLine);

            var linqRes = deptList.Where(x => x.DepartmentId == 101).FirstOrDefault();
            Console.WriteLine("LINQ to find DepartmentName by DeptId: " + linqRes.DepartmentName);

            Console.WriteLine(Environment.NewLine);
        }

        public void ObjectToJSONStringConversion()
        {
            Department dept = new Department() { DepartmentId = 101, DepartmentName = "IT" };
            string strJson = JsonSerializer.Serialize(dept);

            Console.WriteLine("Convert Json to string");
            Console.WriteLine("JSON string result: " + strJson);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
