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

### Dashboard Overview  
<p align="center">
  <img src="<img width="1920" height="850" alt="dashboard1" src="https://github.com/user-attachments/assets/a6036e7a-c708-4c7d-95dd-58bf9e3f7ee6" width="100%" />
</p>
<img width="1920" height="850" alt="dashboard1" src="https://github.com/user-attachments/assets/a6036e7a-c708-4c7d-95dd-58bf9e3f7ee6" />
<img width="1920" height="856" alt="dashboard2" src="https://github.com/user-attachments/assets/c1a09f48-77a4-4487-ba57-3c90ac554766" />
<img width="1920" height="867" alt="Dashboard_Allproduct" src="https://github.com/user-attachments/assets/ed991b62-933c-409a-aba3-74387d8c5562" />
<img width="1920" height="848" alt="dash_AllCategories" src="https://github.com/user-attachments/assets/b2808256-66b2-472d-9a14-93c8f02f4516" />
<img width="1920" height="853" alt="Dash_lowStock" src="https://github.com/user-attachments/assets/3452e1ba-33d4-4ba7-ae30-6f5fb7e65c77" />
<img width="1920" height="853" alt="Dash_ActiveProduct" src="https://github.com/user-attachments/assets/3d6f50a6-9df9-4868-854f-e4a2efff4b0f" />



###  Product Page  
<img width="1920" height="861" alt="products_Index" src="https://github.com/user-attachments/assets/3f406792-da01-49f9-a72a-4b87ded99a6a" />
<img width="1920" height="854" alt="Addproduct_form" src="https://github.com/user-attachments/assets/e83ddc79-dc63-47f5-828a-2dbb84804f4a" />
<img width="1920" height="841" alt="Edit_Product" src="https://github.com/user-attachments/assets/a6df87b9-62f3-407d-8429-8c0e9d7410b9" />
<img width="1920" height="853" alt="P_Added_success" src="https://github.com/user-attachments/assets/fac407d0-61b1-4818-a92e-3d2b96b30e83" />
<img width="1920" height="841" alt="Edit_Product" src="https://github.com/user-attachments/assets/cc86ccfe-bf8b-4e6d-b0be-7981e566359d" />
<img width="1920" height="861" alt="P_Update_Success" src="https://github.com/user-attachments/assets/b64452e5-833f-43b6-9e7b-7e982064baa4" />
<img width="1920" height="861" alt="Warning_product" src="https://github.com/user-attachments/assets/72bfc002-6acb-4d19-aff9-97f03982d117" />
<img width="1920" height="858" alt="Delete_product" src="https://github.com/user-attachments/assets/5dfa5eaf-0bd0-4ac4-9a4d-2bcd10fe5e2c" />


### category Page  
<img width="1920" height="861" alt="categories_Index" src="https://github.com/user-attachments/assets/9e522fc1-1564-431d-a0e2-a405908c6d06" />
<img width="1920" height="849" alt="Add_categories" src="https://github.com/user-attachments/assets/86015ed0-eefe-4b77-b0d4-f72f8fc6c961" />
<img width="1920" height="855" alt="Edit_categories" src="https://github.com/user-attachments/assets/9767fb79-37c0-4383-a1f2-cd5af8601965" />
<img width="1920" height="834" alt="C_Add_Success" src="https://github.com/user-attachments/assets/e38c4976-f6a8-4849-8d64-e998389a091f" />
<img width="1920" height="843" alt="C_Update_success" src="https://github.com/user-attachments/assets/793c5ab3-173e-4c37-b960-1ff54d335334" />
<img width="1920" height="852" alt="Warning_categories" src="https://github.com/user-attachments/assets/61c340f5-9573-49e0-9860-a4bad826b9db" />
<img width="1920" height="864" alt="delete_categories" src="https://github.com/user-attachments/assets/dbeccec7-2b3f-4b16-9603-065e192a881e" />


### Responsive screen tablet and Mobile Screen  
<img width="625" height="843" alt="mobile_respon" src="https://github.com/user-attachments/assets/65feec54-6b16-4f47-81c4-ecbc75311710" />
<img width="625" height="856" alt="mobile_res" src="https://github.com/user-attachments/assets/48584531-8d9a-4102-9315-f8331f01c3fe" />
<img width="608" height="860" alt="mobile res" src="https://github.com/user-attachments/assets/c25fed45-29bf-4193-97df-0bb7c274e434" />


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
