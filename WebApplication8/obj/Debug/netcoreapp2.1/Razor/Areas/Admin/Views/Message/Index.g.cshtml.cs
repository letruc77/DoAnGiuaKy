#pragma checksum "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de531c7bca676682cc8ec9867173ebef193ce2f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Message/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Message_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de531c7bca676682cc8ec9867173ebef193ce2f7", @"/Areas/Admin/Views/Message/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2dbf9650d50b49d3e3ce7a646256dc19e70a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/ChatService/admin_process_chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4760, true);
            WriteLiteral(@"<style>
    body {
        padding-top: 0;
        font-size: 12px;
        color: #777;
        background: #f9f9f9;
        font-family: 'Open Sans',sans-serif;
        /*margin-top:20px;*/
    }

    .bg-white {
        background-color: #fff;
    }

    .friend-list {
        list-style: none;
        margin-left: -40px;
    }

        .friend-list li {
            border-bottom: 1px solid #eee;
        }

            .friend-list li a img {
                float: left;
                width: 45px;
                height: 45px;
                margin-right: 0px;
            }

            .friend-list li a {
                position: relative;
                display: block;
                padding: 10px;
                transition: all .2s ease;
                -webkit-transition: all .2s ease;
                -moz-transition: all .2s ease;
                -ms-transition: all .2s ease;
                -o-transition: all .2s ease;
            }

            .friend");
            WriteLiteral(@"-list li.active a {
                background-color: #f1f5fc;
            }

            .friend-list li a .friend-name,
            .friend-list li a .friend-name:hover {
                color: #777;
            }

            .friend-list li a .last-message {
                width: 65%;
                white-space: nowrap;
                text-overflow: ellipsis;
                overflow: hidden;
            }

            .friend-list li a .time {
                position: absolute;
                top: 10px;
                right: 8px;
            }

    small, .small {
        font-size: 85%;
    }

    .friend-list li a .chat-alert {
        position: absolute;
        right: 8px;
        top: 27px;
        font-size: 10px;
        padding: 3px 5px;
    }

    .chat-message {
        padding: 60px 20px 115px;
    }

    .chat {
        list-style: none;
        margin: 0;
    }

    .chat-message {
        background: #f9f9f9;
    }

    .chat li img {
  ");
            WriteLiteral(@"      width: 45px;
        height: 45px;
        border-radius: 50em;
        -moz-border-radius: 50em;
        -webkit-border-radius: 50em;
    }

    img {
        max-width: 100%;
    }

    .chat-body {
        padding-bottom: 20px;
    }

    .chat li.left .chat-body {
        margin-left: 70px;
        background-color: #fff;
    }

    .chat li .chat-body {
        position: relative;
        font-size: 11px;
        padding: 10px;
        border: 1px solid #f1f5fc;
        box-shadow: 0 1px 1px rgba(0,0,0,.05);
        -moz-box-shadow: 0 1px 1px rgba(0,0,0,.05);
        -webkit-box-shadow: 0 1px 1px rgba(0,0,0,.05);
    }

        .chat li .chat-body .header {
            padding-bottom: 5px;
            border-bottom: 1px solid #f1f5fc;
        }

        .chat li .chat-body p {
            margin: 0;
        }

    .chat li.left .chat-body:before {
        position: absolute;
        top: 10px;
        left: -8px;
        display: inline-block;
        bac");
            WriteLiteral(@"kground: #fff;
        width: 16px;
        height: 16px;
        border-top: 1px solid #f1f5fc;
        border-left: 1px solid #f1f5fc;
        content: '';
        transform: rotate(-45deg);
        -webkit-transform: rotate(-45deg);
        -moz-transform: rotate(-45deg);
        -ms-transform: rotate(-45deg);
        -o-transform: rotate(-45deg);
    }

    .chat li.right .chat-body:before {
        position: absolute;
        top: 10px;
        right: -8px;
        display: inline-block;
        background: #fff;
        width: 16px;
        height: 16px;
        border-top: 1px solid #f1f5fc;
        border-right: 1px solid #f1f5fc;
        content: '';
        transform: rotate(45deg);
        -webkit-transform: rotate(45deg);
        -moz-transform: rotate(45deg);
        -ms-transform: rotate(45deg);
        -o-transform: rotate(45deg);
    }

    .chat li {
        margin: 15px 0;
    }

        .chat li.right .chat-body {
            margin-right: 70px;
        ");
            WriteLiteral(@"    background-color: #fff;
        }

    .chat-box {
        position: fixed;
        bottom: 0;
        left: 444px;
        right: 0;
        padding: 15px;
        border-top: 1px solid #eee;
        transition: all .5s ease;
        -webkit-transition: all .5s ease;
        -moz-transition: all .5s ease;
        -ms-transition: all .5s ease;
        -o-transition: all .5s ease;
    }

    .primary-font {
        color: #3c8dbc;
    }

    a:hover, a:active, a:focus {
        text-decoration: none;
        outline: 0;
    }
</style>
<h2 class=""text-center"">Management Chat Messages</h2>
<input type=""hidden"" id=""username-chat""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4760, "\"", 4787, 1);
#line 198 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Message\Index.cshtml"
WriteAttributeValue("", 4768, User.Identity.Name, 4768, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4788, 8474, true);
            WriteLiteral(@" />
<input type=""hidden"" id=""guest-selected"" value="""" />
<div class=""bootstrap snippet"">
    <div class=""row"" style=""margin-left:3px"">
        <div class=""col-md-4 bg-white "" style=""max-height:400px;overflow-y:scroll"">
            <div class=""row border-bottom padding-sm"" style=""height: 40px;"">
                <h4 style=""text-align:center""><u>Guest Customer</u></h4>
            </div>

            <!-- =============================================================== -->
            <!-- member list -->
            <ul class=""friend-list"" id=""list-guest-chat"">
                <!--
                   <li class=""active bounceInDown"">
                    <a href=""#ct-1"" class=""clearfix"" data-toggle=""pill"">
                        <img src=""https://bootdey.com/img/Content/user_1.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>John Doe</strong>
                        </div>
                        <div class=""last-message text-");
            WriteLiteral(@"muted"">Hello, Are you there?</div>
                        <small class=""time text-muted"">Just now</small>
                        <small class=""chat-alert label label-danger"">1</small>
                    </a>
                </li>
                <li>
                    <a href=""#ct-2"" class=""clearfix"" data-toggle=""pill"">
                        <img src=""https://bootdey.com/img/Content/user_2.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>Jane Doe</strong>
                        </div>
                        <div class=""last-message text-muted"">Lorem ipsum dolor sit amet.</div>
                        <small class=""time text-muted"">5 mins ago</small>
                        <small class=""chat-alert text-muted""><i class=""fa fa-check""></i></small>
                    </a>
                </li>
                <li>
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/i");
            WriteLiteral(@"mg/Content/user_3.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>Kate</strong>
                        </div>
                        <div class=""last-message text-muted"">Lorem ipsum dolor sit amet.</div>
                        <small class=""time text-muted"">Yesterday</small>
                        <small class=""chat-alert text-muted""><i class=""fa fa-reply""></i></small>
                    </a>
                </li>
                <li>
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_1.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>Kate</strong>
                        </div>
                        <div class=""last-message text-muted"">Lorem ipsum dolor sit amet.</div>
                        <small class=""time text-muted"">Yesterday</small>
                        <small class=""c");
            WriteLiteral(@"hat-alert text-muted""><i class=""fa fa-reply""></i></small>
                    </a>
                </li>
                <li>
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_2.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>Kate</strong>
                        </div>
                        <div class=""last-message text-muted"">Lorem ipsum dolor sit amet.</div>
                        <small class=""time text-muted"">Yesterday</small>
                        <small class=""chat-alert text-muted""><i class=""fa fa-reply""></i></small>
                    </a>
                </li>
                <li>
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_6.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>Kate</strong>
     ");
            WriteLiteral(@"                   </div>
                        <div class=""last-message text-muted"">Lorem ipsum dolor sit amet.</div>
                        <small class=""time text-muted"">Yesterday</small>
                        <small class=""chat-alert text-muted""><i class=""fa fa-reply""></i></small>
                    </a>
                </li>
                <li>
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_5.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>Kate</strong>
                        </div>
                        <div class=""last-message text-muted"">Lorem ipsum dolor sit amet.</div>
                        <small class=""time text-muted"">Yesterday</small>
                        <small class=""chat-alert text-muted""><i class=""fa fa-reply""></i></small>
                    </a>
                </li>
                <li>
                    <a href=");
            WriteLiteral(@"""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_2.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>Jane Doe</strong>
                        </div>
                        <div class=""last-message text-muted"">Lorem ipsum dolor sit amet.</div>
                        <small class=""time text-muted"">5 mins ago</small>
                        <small class=""chat-alert text-muted""><i class=""fa fa-check""></i></small>
                    </a>
                </li>
                <li class=""active bounceInDown"">
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_1.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>John Doe</strong>
                        </div>
                        <div class=""last-message text-muted"">Hello, Are you there?</div>
    ");
            WriteLiteral(@"                    <small class=""time text-muted"">Just now</small>
                        <small class=""chat-alert label label-danger"">1</small>
                    </a>
                </li>
                <li class=""active bounceInDown"">
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_1.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>John Doe</strong>
                        </div>
                        <div class=""last-message text-muted"">Hello, Are you there?</div>
                        <small class=""time text-muted"">Just now</small>
                        <small class=""chat-alert label label-danger"">1</small>
                    </a>
                </li>
                <li class=""active bounceInDown"">
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_1.jpg"" alt="""" cla");
            WriteLiteral(@"ss=""img-circle"">
                        <div class=""friend-name"">
                            <strong>John Doe</strong>
                        </div>
                        <div class=""last-message text-muted"">Hello, Are you there?</div>
                        <small class=""time text-muted"">Just now</small>
                        <small class=""chat-alert label label-danger"">1</small>
                    </a>
                </li>
                <li class=""active bounceInDown"">
                    <a href=""#"" class=""clearfix"">
                        <img src=""https://bootdey.com/img/Content/user_1.jpg"" alt="""" class=""img-circle"">
                        <div class=""friend-name"">
                            <strong>John Doe</strong>
                        </div>
                        <div class=""last-message text-muted"">Hello, Are you there?</div>
                        <small class=""time text-muted"">Just now</small>
                        <small class=""chat-alert label label-danger""");
            WriteLiteral(@">1</small>
                    </a>
                </li>
                -->
            </ul>
        </div>

        <!--=========================================================-->
        <!-- selected chat -->
        <div class=""tab-content"" id=""tab-content-chat"">
");
            EndContext();
#line 350 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Message\Index.cshtml"
              
                /*
            }  <div id="ct-1" class="col-md-8 bg-white tab-pane fade in active" style="max-height:400px;overflow-y:scroll">
                  <div class="chat-message">
                      <ul class="chat">
                          <li class="left clearfix">
                              <span class="chat-img pull-left">
                                  <img src="https://bootdey.com/img/Content/user_3.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">John Doe</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 12 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                                  </p>
                              </div>
                          </li>
                          <li class="right clearfix">
                              <span class="chat-img pull-right">
                                  <img src="https://bootdey.com/img/Content/user_1.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">Sarah</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 13 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales at.
                                  </p>
                              </div>
                          </li>
                          <li class="left clearfix">
                              <span class="chat-img pull-left">
                                  <img src="https://bootdey.com/img/Content/user_3.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">John Doe</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 12 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                                  </p>
                              </div>
                          </li>
                          <li class="right clearfix">
                              <span class="chat-img pull-right">
                                  <img src="https://bootdey.com/img/Content/user_1.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">Sarah</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 13 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales at.
                                  </p>
                              </div>
                          </li>
                          <li class="left clearfix">
                              <span class="chat-img pull-left">
                                  <img src="https://bootdey.com/img/Content/user_3.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">John Doe</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 12 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                                  </p>
                              </div>
                          </li>
                          <li class="right clearfix">
                              <span class="chat-img pull-right">
                                  <img src="https://bootdey.com/img/Content/user_1.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">Sarah</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 13 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales at.
                                  </p>
                              </div>
                          </li>
                          <li class="right clearfix">
                              <span class="chat-img pull-right">
                                  <img src="https://bootdey.com/img/Content/user_1.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">Sarah</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 13 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales at.
                                  </p>
                              </div>
                          </li>
                      </ul>
                  </div>
                  <div class="chat-box bg-white">
                      <div class="input-group">
                          <input class="form-control border no-shadow no-rounded" placeholder="Type your message here">
                          <span class="input-group-btn">
                              <button class="btn btn-success no-rounded" type="button">Send</button>
                          </span>
                      </div><!-- /input-group -->
                  </div>
              </div>
              <div id="ct-2" class="col-md-8 bg-white tab-pane fade" style="max-height:400px;overflow-y:scroll">
                  <div class="chat-message">
                      <ul class="chat">
                          <li class="right clearfix">
                              <span class="chat-img pull-right">
                                  <img src="https://bootdey.com/img/Content/user_1.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">Sarah</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 13 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales at.
                                  </p>
                              </div>
                          </li>
                          <li class="right clearfix">
                              <span class="chat-img pull-right">
                                  <img src="https://bootdey.com/img/Content/user_1.jpg" alt="User Avatar">
                              </span>
                              <div class="chat-body clearfix">
                                  <div class="header">
                                      <strong class="primary-font">Sarah</strong>
                                      <small class="pull-right text-muted"><i class="fa fa-clock-o"></i> 13 mins ago</small>
                                  </div>
                                  <p>
                                      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales at.
                                  </p>
                              </div>
                          </li>
                      </ul>
                  </div>

              </div>
             @{
                 */
            

#line default
#line hidden
            BeginContext(22795, 836, true);
            WriteLiteral(@"
        </div>
        <div class=""chat-box bg-white hidden"">
            <div class=""input-group"">
                <input class=""form-control border no-shadow no-rounded"" id=""textbox-message"" placeholder=""Type your message here"">
                <span class=""input-group-btn"">
                    <button class=""btn btn-success no-rounded"" id=""btn-send-message"" type=""button"">Send</button>
                </span>
            </div><!-- /input-group -->
        </div>
    </div>
</div>


<!-- Modal -->
<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-sm"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-body text-center"">
                <p>Loading Data ...</p>
            </div>

        </div>

    </div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(23648, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(23654, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc15ae31e7ee488c83e7ca539f2401aa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(23702, 90, true);
                WriteLiteral("\r\n    <!--<script src=\"/signalr/hubs\"></script>-->\r\n    <input type=\"hidden\" id=\"base_url\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 23792, "\"", 23847, 1);
#line 533 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Message\Index.cshtml"
WriteAttributeValue("", 23800, Url.RouteUrl(new {controller="/", area = "" }), 23800, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(23848, 49, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"base_url_admin\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 23897, "\"", 23957, 1);
#line 534 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Message\Index.cshtml"
WriteAttributeValue("", 23905, Url.RouteUrl(new {controller="/", area = "admin" }), 23905, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(23958, 9, true);
                WriteLiteral(" />\r\n    ");
                EndContext();
                BeginContext(23967, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4fadf9b421b428e926f1bf5f29b65e0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(24034, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591