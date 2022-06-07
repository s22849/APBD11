#pragma checksum "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "115a6f2346af3f2d1137a7643cd0442f4f5dfa5d"
// <auto-generated/>
#pragma warning disable 1591
namespace APBD10.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using APBD10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using APBD10.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\julia\Desktop\APBD10\_Imports.razor"
using APBD10.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students/{ID:int}")]
    public partial class StudentDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-bcfy4vx7n5>Student\'s Details</h3><br b-bcfy4vx7n5>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "column");
            __builder.AddAttribute(3, "b-bcfy4vx7n5");
            __builder.AddMarkupContent(4, "<label class=\"label\" for=\"fname\" b-bcfy4vx7n5>First name:</label>\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", 
#nullable restore
#line 9 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
               Student.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "id", "fname");
            __builder.AddAttribute(8, "disabled");
            __builder.AddAttribute(9, "b-bcfy4vx7n5");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.AddMarkupContent(11, "<label class=\"label\" for=\"lname\" b-bcfy4vx7n5>Last name:</label>\r\n");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 12 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
               Student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "id", "lname");
            __builder.AddAttribute(15, "disabled");
            __builder.AddAttribute(16, "b-bcfy4vx7n5");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.AddMarkupContent(18, "<label class=\"label\" for=\"birth\" b-bcfy4vx7n5>Birthdate:</label>\r\n");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 15 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
               Student.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "id", "birth");
            __builder.AddAttribute(22, "disabled");
            __builder.AddAttribute(23, "b-bcfy4vx7n5");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "<br b-bcfy4vx7n5>\r\n\r\n");
            __builder.AddMarkupContent(25, "<label class=\"label\" for=\"stud\" b-bcfy4vx7n5>Studies:</label>\r\n");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 18 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
               Student.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "id", "stud");
            __builder.AddAttribute(29, "disabled");
            __builder.AddAttribute(30, "b-bcfy4vx7n5");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "<br b-bcfy4vx7n5>   \r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "position:relative; top:20px;");
            __builder.AddAttribute(34, "b-bcfy4vx7n5");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn3");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
                               Return

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "b-bcfy4vx7n5");
            __builder.AddContent(39, "Return");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "column");
            __builder.AddAttribute(43, "b-bcfy4vx7n5");
            __builder.AddMarkupContent(44, "<label class=\"label\" for=\"avatar\" b-bcfy4vx7n5>Avatar:</label>\r\n");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "value", 
#nullable restore
#line 28 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
               Student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "id", "avatar");
            __builder.AddAttribute(48, "disabled");
            __builder.AddAttribute(49, "b-bcfy4vx7n5");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "<br b-bcfy4vx7n5>\r\n");
            __builder.OpenElement(51, "img");
            __builder.AddAttribute(52, "alt", (
#nullable restore
#line 29 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
            Student.Name

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 29 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
                            Student.LastName

#line default
#line hidden
#nullable disable
            ) + " Avatar");
            __builder.AddAttribute(53, "src", 
#nullable restore
#line 29 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
                                                            Student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "b-bcfy4vx7n5");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "<br b-bcfy4vx7n5>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\julia\Desktop\APBD10\Pages\StudentDetails.razor"
       
    [Parameter]
    public int ID { get; set; }

    public Student Student { get; set; }

    protected override void OnInitialized()
    {
        Student = StudentService.GetStudent(ID);
    }

    private void Return()
    {
        navigator.NavigateTo("/students");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591