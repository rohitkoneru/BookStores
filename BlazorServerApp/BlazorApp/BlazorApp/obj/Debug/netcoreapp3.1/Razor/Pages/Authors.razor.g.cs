#pragma checksum "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117e9f2fb1d08d3a33e217b3576d5b926f854980"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
using BlazorServerApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class Authors : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3><b>Enter Author Information</b></h3>\r\n    <hr>\r\n\r\n    ");
            __builder.OpenComponent<CuriousDriveRazorLibrary.ServerValidations>(4);
            __builder.AddAttribute(5, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                  IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Result", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                     Result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddContent(9, 
#nullable restore
#line 17 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
         RecordName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                      author

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                              SaveAuthor

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-12 row");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<label class=\"col-2 font-weight-bold\">first name :</label>\r\n            ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "class", "form-control col-3");
                __builder2.AddAttribute(23, "placeholder", "first name");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                                             author.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => author.FirstName = __value, author.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddElementReferenceCapture(26, (__value) => {
#nullable restore
#line 25 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                         firstNameTextBox = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            &nbsp;");
                __Blazor.BlazorServerApp.Pages.Authors.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 26 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                            () => author.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-12 row");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<label class=\"col-2 font-weight-bold\">last name :</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control col-3");
                __builder2.AddAttribute(38, "placeholder", "last name");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                               author.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => author.LastName = __value, author.LastName))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => author.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            &nbsp;");
                __Blazor.BlazorServerApp.Pages.Authors.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 32 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                            () => author.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-12 row");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.AddMarkupContent(50, "<label class=\"col-2 font-weight-bold\">city :</label>            \r\n            ");
                __builder2.OpenComponent<CuriousDriveRazorLibrary.SelectCity>(51);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-12 row");
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.AddMarkupContent(57, "<label class=\"col-2 font-weight-bold\">email address :</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control col-3");
                __builder2.AddAttribute(60, "placeholder", "email address");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                               author.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => author.EmailAddress = __value, author.EmailAddress))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => author.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n            &nbsp;");
                __Blazor.BlazorServerApp.Pages.Authors.TypeInference.CreateValidationMessage_2(__builder2, 65, 66, 
#nullable restore
#line 43 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                            () => author.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n        <br>        \r\n        ");
                __builder2.AddMarkupContent(69, @"<div class=""col-12 row"">
            <span class=""col-2""></span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Save"">
            <span>&nbsp;</span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Clear"">
        </div>
    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n<br>\r\n");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col-10");
            __builder.AddMarkupContent(74, "\r\n\r\n    ");
            __builder.AddMarkupContent(75, "<h3><b>Authors</b></h3>\r\n");
#nullable restore
#line 58 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
     if (authorList != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "        ");
            __builder.OpenElement(77, "table");
            __builder.AddAttribute(78, "class", "table");
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "thead");
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "tr");
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.AddMarkupContent(84, "<th>AuthorId</th>\r\n                    ");
            __builder.AddMarkupContent(85, "<th>First Name</th>\r\n                    ");
            __builder.AddMarkupContent(86, "<th>Last Name</th>\r\n                    ");
            __builder.AddMarkupContent(87, "<th>Email Address</th>                    \r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(88);
            __builder.AddAttribute(89, "Roles", "Publisher");
            __builder.AddAttribute(90, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(91, "\r\n                            ");
                __builder2.AddMarkupContent(92, "<th>Actions</th>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenElement(96, "tbody");
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 76 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                 foreach (var author in authorList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                ");
            __builder.OpenElement(99, "tr");
            __builder.AddMarkupContent(100, "\r\n                    ");
            __builder.OpenElement(101, "td");
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(103);
            __builder.AddAttribute(104, "href", 
#nullable restore
#line 80 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                       string.Format("/authors/authordetail/{0}", @author.AuthorId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(106, "\r\n                            ");
                __builder2.AddContent(107, 
#nullable restore
#line 81 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                             author.AuthorId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(108, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "td");
            __builder.AddContent(112, 
#nullable restore
#line 84 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                         author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenElement(114, "td");
            __builder.AddContent(115, 
#nullable restore
#line 85 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                         author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                    ");
            __builder.OpenElement(117, "td");
            __builder.AddContent(118, 
#nullable restore
#line 87 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                         author.EmailAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "                   \r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(120);
            __builder.AddAttribute(121, "Roles", "Publisher");
            __builder.AddAttribute(122, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(123, "\r\n                            ");
                __builder2.OpenElement(124, "th");
                __builder2.AddMarkupContent(125, "\r\n                                ");
                __builder2.OpenElement(126, "a");
                __builder2.AddAttribute(127, "style", "text-underline-position:below; cursor:pointer; color:blue");
                __builder2.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                                                                               (() => EditAuthor(author))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(129, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, " |\r\n                                ");
                __builder2.OpenElement(131, "a");
                __builder2.AddAttribute(132, "style", "text-underline-position:below; cursor:pointer; color:blue");
                __builder2.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                                                                               (() => DeleteAuthor(author.AuthorId))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(134, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(137, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
#nullable restore
#line 98 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(139, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n");
#nullable restore
#line 101 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
    }
    else
    { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, "        ");
            __builder.OpenComponent<CuriousDriveRazorLibrary.NoResultMessage>(143);
            __builder.CloseComponent();
            __builder.AddMarkupContent(144, "\r\n");
#nullable restore
#line 105 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(145, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
       

    public Author author { get; set; }
    public List<Author> authorList { get; set; }
    public string SelectedCity { get; set; }

    public bool IsVisible { get; set; }
    public bool Result { get; set; }
    public string RecordName { get; set; }
    public string[] Cities { get; set; }

    ElementReference firstNameTextBox;

    protected override void OnInitialized()
    {
        Console.WriteLine("Authors - OnInitialized");
        base.OnInitialized();        
    }

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Authors - OnInitializedAsync");

        author = new Author();
        authorList = new List<Author>();
        //authorList = await authorService.GetAuthors();

        await base.OnInitializedAsync();
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("Authors - OnParametersSet");
        base.OnParametersSet();
    }

    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine("Authors - OnParametersSetAsync");
        await base.OnParametersSetAsync();
    }

    protected override bool ShouldRender()
    {
        base.ShouldRender();
        Console.WriteLine("Authors - ShouldRender");

        return true;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("Authors - OnAfterRender - firstRender = " + firstRender);
        base.OnAfterRender(firstRender);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine("Authors - OnAfterRenderAsync - firstRender = " + firstRender);

        if (firstRender)
            await LoadAuthors();

        await base.OnAfterRenderAsync(firstRender);
    }

    public void Dispose()
    {
        Console.WriteLine("Authors - Dispose");
    }

    private async Task LoadAuthors()
    {
        authorList = await bookStoresService.GetAllAsync("authors/");

        if (authorList == null)
        {
            RefreshRequest refreshRequest = new RefreshRequest();
            refreshRequest.AccessToken = await localStorageService.GetItemAsync<string>("accessToken");
            refreshRequest.RefreshToken = await localStorageService.GetItemAsync<string>("refreshToken");

            var user1 = await userService.RefreshTokenAsync(refreshRequest);
            await localStorageService.SetItemAsync("accessToken", user1.AccessToken);

            authorList = await bookStoresService.GetAllAsync("authors/");
        }

        StateHasChanged();
    }

    private async Task SaveAuthor()
    {
        if (author.AuthorId == 0)
            await bookStoresService.SaveAsync("authors/", author);
        else
            await bookStoresService.UpdateAsync("authors/", author.AuthorId, author);

        await LoadAuthors();

        Result = true;
        IsVisible = true;

        var firstName = author.FirstName;
        var lastName = author.LastName;

        RecordName = firstName + " " + lastName;

        author = new Author();

        //await JSRuntime.InvokeVoidAsync("saveMessage", firstName, lastName);
        await JSRuntime.InvokeVoidAsync("setFocusOnElement", firstNameTextBox);
    }

    private async Task DeleteAuthor(int authorId)
    {
        await bookStoresService.DeleteAsync("authors/", authorId);
        await LoadAuthors();

        //throw new Exception("DeleteAuthor");
    }

    private void EditAuthor(Author argAuthor)
    {
        author = argAuthor;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookStoresService<Author> bookStoresService { get; set; }
    }
}
namespace __Blazor.BlazorServerApp.Pages.Authors
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
