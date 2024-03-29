using Employee1.DAL;
using Employee1.Models;
using Employee1.Models.DBEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Employee1.Controllers
{
    public class EmployeeController : Controller
    {
      private readonly EmployeeDbContext _context;
       public EmployeeController(EmployeeDbContext context)
        {
            this._context = context;
            
        }
        [HttpGet]
		public IActionResult Index()
		{
	
			var employees = _context.Empoyees.ToList();
			if (employees != null)
			{
				List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();
				ViewBag.Employees = employeeList;
				foreach (var employee in employees)
				{
					var EmployeeViewModel = new EmployeeViewModel()
					{
						EmployeeID = employee.EmployeeID,
						Name = employee.Name,
						Address = employee.Address,
						DateOfBirth = employee.DateOfBirth,
						ContactNo = employee.ContactNo,
						Qualification = employee.Qualification,
						PreviousCompanyName = employee.PreviousCompanyName,
						Status = employee.Status,
						Action = employee.Action,
					};
					employeeList.Add(EmployeeViewModel);

				}
				return View(employeeList);
			}

			return View(employees);
		}
		public IActionResult Add()
		{
			return View("Add");
		}
		public IActionResult Edit(int employeeId)
        {
            try
            {
				var existingData = _context.Empoyees.FirstOrDefault(x => x.EmployeeID == employeeId);
				if (existingData == null) throw new Exception("Data not found.");

				ViewBag.EmployeeID = employeeId;
				ViewBag.Name = existingData.Name;
				ViewBag.Address = existingData.Address;
				ViewBag.DateOfBirth = existingData.DateOfBirth;
				ViewBag.ContactNo = existingData.ContactNo;
				ViewBag.Qualification = existingData.Qualification;
				ViewBag.PreviousCompanyName = existingData.PreviousCompanyName;
				ViewBag.Status = existingData.Status;

			}
			catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
			return View("Edit");
        }

        [HttpPost]
        public IActionResult Insert(EmployeeViewModel employeeViewModel)
        {
            
            try
            {
                if (employeeViewModel == null)
                    throw new ArgumentNullException();

                var employee = new Employee { 
                EmployeeID= employeeViewModel.EmployeeID,
                Name = employeeViewModel.Name,
                Address = employeeViewModel.Address,
                DateOfBirth= employeeViewModel.DateOfBirth,
                ContactNo = employeeViewModel.ContactNo,
                Qualification = employeeViewModel.Qualification,
                PreviousCompanyName = employeeViewModel.PreviousCompanyName,
                Status = employeeViewModel.Status,
                Action = employeeViewModel.Action,
                };

                _context.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
                //return Redirect("Index");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

		}

		[HttpPut]
		public IActionResult Update(EmployeeViewModel employeeViewModel)
		{
            try
            {
                var existedEmployee = _context.Empoyees.FirstOrDefault(x => x.EmployeeID == employeeViewModel.EmployeeID);
				if (existedEmployee == null)
					throw new Exception("Data not found.");

				existedEmployee.Name = employeeViewModel.Name;
                existedEmployee.Address = employeeViewModel.Address;
                existedEmployee.DateOfBirth = employeeViewModel.DateOfBirth;
                existedEmployee.ContactNo = employeeViewModel.ContactNo;
                existedEmployee.Qualification = employeeViewModel.Qualification;
                existedEmployee.PreviousCompanyName = employeeViewModel.PreviousCompanyName;
                existedEmployee.Status = employeeViewModel.Status;
                _context.Empoyees.Update(existedEmployee);
                _context.SaveChanges(true);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
			
			return RedirectToAction("Index");
		}
		public IActionResult Delete(int employeeId)
		{
			try
			{
				var existedEmployee = _context.Empoyees.FirstOrDefault(x => x.EmployeeID == employeeId);
				if (existedEmployee == null) throw new Exception("Employee not found.");

				_context.Empoyees.Remove(existedEmployee);
				_context.SaveChanges();
				return RedirectToAction("Index");


			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

	}

   
}
