using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace InsideDotNet.InsideDemos
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
    }

    internal class JsonObjectsDemo
    {
        public void ConvertJsonToObject()
        {
            string jsonData = "{\"DeptId\": 101, \"DepartmentName\": \"IT\"}";

            Department deptObj = JsonSerializer.Deserialize<Department>(jsonData);

            Console.WriteLine("Convert Json To Object");
            Console.WriteLine("Department Id: {0}", deptObj.DeptId);
            Console.WriteLine("Department Name: {0}", deptObj.DepartmentName);
        }

        public void ConvertJsonArrayToList()
        {
            string jsonArray = "[{\"DeptId\": 101,\"DepartmentName\":\"IT\" }, " +
                                "{\"DeptId\": 102,\"DepartmentName\":\"Accounts\" }]";

            var deptList = JsonSerializer.Deserialize<IList<Department>>(jsonArray);

            Console.WriteLine("Convert Json Array To List");

            foreach (var dept in deptList)
            {
                Console.WriteLine("Department Id is: {0}", dept.DeptId);
                Console.WriteLine("Department Name is: {0}", dept.DepartmentName);
            }

            var linqRes = deptList.Where(x => x.DeptId == 101).FirstOrDefault();
            Console.WriteLine("LINQ to find DepartmentName by DeptId: " + linqRes.DepartmentName);
        }

        public void ObjectToJSONStringConversion()
        {
            Department dept = new Department() { DeptId = 101, DepartmentName = "IT" };
            string strJson = JsonSerializer.Serialize(dept);

            Console.WriteLine("Convert Json to string");
            Console.WriteLine("JSON string result: " + strJson);
        }
    }
}
