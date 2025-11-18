# 📦 Project Overview
---
This project is an Inventory Management System designed to help users efficiently manage products and categories. Users can add, view, edit, and delete products, and the system also provides a REST API for integration with other applications.  
The Smart Inventory Dashboard provides a clear and interactive view of the inventory. It shows key metrics such as total products, total categories, low-stock items, and active products through summary cards, which can be clicked to see more details. The dashboard also includes a recent products table displaying the latest items, highlighting products with low stock for easy monitoring.  
The dashboard is fully responsive, so it works well on mobile devices, tablets, and desktop computers. Additional features include a refresh button, color-coded status badges, and hover effects for better visibility. The interface is simple, clean, and easy to use, making inventory management faster and more efficient.

---

# 🛠️ Technologies Used
---
Backend: ASP.NET Core MVC, C#  
Frontend: HTML, CSS, JavaScript  
Data Storage: JSON files (managed via a custom DataService)  
Styling & Layout: CSS & Bootstrap for responsive design  
Development Environment: Visual Studio 2022  
APIs: REST API endpoints for managing products and categories  

---

# ⚙️ Setup Instructions (Backend & Frontend)
---
**Download the Project**  
Go to your GitHub repository.  
Click Code → Download ZIP.  
Extract the ZIP file to a folder on your computer.

**Open in Visual Studio 2022**  
Launch Visual Studio.  
Click Open a project or solution and select **Inventory_Management.sln**.

**Restore and Build**  
Visual Studio will automatically restore all NuGet packages.  
Build the project to ensure everything is set up correctly.

**Run the Project**  
Press F5 or click Run in Visual Studio.  
The application will start, and you can open it in your browser.

**Frontend and Backend Together**  
Since this is an ASP.NET Core MVC project, the frontend pages (Views) and assets (wwwroot) are already included.  
No separate frontend setup is required, everything runs together.

---

# 🚀 How to Run the Project
---
**Open the Project in Visual Studio**  
Open the file Inventory_Management.sln in Visual Studio.

**Build the Project**  
Visual Studio will automatically restore any missing NuGet packages.  
Build the project to ensure there are no errors.

**Start the Application**  
Press F5 or click Run in Visual Studio.  
The application will start, and your default web browser will open the dashboard.

**Use the Dashboard**  
You can view, add, edit, and delete products.  
Monitor inventory using the summary cards, recent products table, and other interactive features.

**API Access (Optional)**  
The REST API endpoints are available at **/api/products** and **/api/categories**.  
You can use these endpoints to interact with the data programmatically.

---

# 🖼️ Screenshots
---
Replace the images below with your own project screenshots.

### Dashboard Overview  
Shows the summary cards, recent products table, and overall inventory status.

### Add Product Page  
The form used to add new products to the inventory.

### Edit Product Page  
Edit existing product details easily through this interface.

### Low Stock Products  
Highlights products with low stock for quick monitoring.

---

# ⚠️ Known Limitations
---
**No User Authentication**  
The system does not include login, user roles, or access control. Anyone using the application can access and modify the data.

**Data Storage**  
All data is stored in local JSON files. This approach is not suitable for large-scale use, multiple users at the same time, or cloud deployment.

**Error Handling**  
The system has basic error handling. Some unexpected errors may not show clear or user-friendly messages.

**Limited Validation**  
Input validation for products and categories is minimal. Some invalid or incomplete entries may still be accepted.

**No Notifications**  
The system does not send alerts or notifications for low stock or other important events.

**No Multi-Language Support**  
All text and labels are in English. There is no option to use other languages.

**No Backup or Restore Feature**  
There is no built-in way to backup or restore inventory data. Accidental deletions could result in permanent loss of data.

---
