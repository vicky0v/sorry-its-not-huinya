#pragma checksum "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4941d1a6581c6ab0db21eaffd2742009b404c498"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Learner.Client.Post
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
using Blazor.Learner.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class Form : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>OurPageOne</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                  post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label>Author :</label>\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                     post.Author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => post.Author = __value, post.Author))));
                __builder2.AddAttribute(14, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => post.Author));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __Blazor.Blazor.Learner.Client.Post.Form.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 12 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                      () => post.Author

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group ");
                __builder2.OpenElement(21, "div");
                __builder2.AddMarkupContent(22, "<label>Name :</label>\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                         post.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => post.Name = __value, post.Name))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => post.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __Blazor.Blazor.Learner.Client.Post.Form.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 20 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                          () => post.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group ");
                __builder2.OpenElement(34, "div");
                __builder2.AddMarkupContent(35, "<label>Category :</label>\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                         post.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => post.Category = __value, post.Category))));
                __builder2.AddAttribute(40, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => post.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __Blazor.Blazor.Learner.Client.Post.Form.TypeInference.CreateValidationMessage_2(__builder2, 42, 43, 
#nullable restore
#line 29 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                          () => post.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group ");
                __builder2.OpenElement(47, "div");
                __builder2.AddMarkupContent(48, "<label>Content :</label>\r\n            ");
                __builder2.OpenElement(49, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                         post.Content

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => post.Content = __value, post.Content))));
                __builder2.AddAttribute(53, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => post.Content));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                ");
                __Blazor.Blazor.Learner.Client.Post.Form.TypeInference.CreateValidationMessage_3(__builder2, 55, 56, 
#nullable restore
#line 38 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                          () => post.Content

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group ");
                __builder2.OpenElement(60, "div");
                __builder2.AddMarkupContent(61, "<label>Date :</label>\r\n            ");
                __builder2.OpenElement(62, "div");
                __Blazor.Blazor.Learner.Client.Post.Form.TypeInference.CreateInputDate_4(__builder2, 63, 64, 
#nullable restore
#line 46 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                         post.Date

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => post.Date = __value, post.Date)), 66, () => post.Date);
                __builder2.AddMarkupContent(67, "\r\n                ");
                __Blazor.Blazor.Learner.Client.Post.Form.TypeInference.CreateValidationMessage_5(__builder2, 68, 69, 
#nullable restore
#line 47 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
                                          () => post.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n    ");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "type", "submit");
                __builder2.AddAttribute(73, "class", "btn btn-success");
#nullable restore
#line 53 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
__builder2.AddContent(74, ButtonText);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Form.razor"
       
    [Parameter] public Post post { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Blazor.Learner.Client.Post.Form
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
