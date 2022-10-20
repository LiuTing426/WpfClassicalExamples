using Demo84.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Demo84.Services
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IEmployeeService”。
    //服务契约
    [ServiceContract]
    public interface IEmployeeService
    {
        /* [OperationContract]
         void DoWork();*/
        //操作协定
        [OperationContract]
        Employee GetEmployeeByID(string employeeID);

        [OperationContract]
        List<Employee> GetEmployees();

        [OperationContract]
        void InsertEmployee(Employee employee);
    }
}
