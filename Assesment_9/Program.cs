using Assesment_9;
using Assesment_9.Services.Comments;
using Assesment_9.Services.Posts;
using Assesment_9.Services.User;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped<ICommentService, CommentsService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
