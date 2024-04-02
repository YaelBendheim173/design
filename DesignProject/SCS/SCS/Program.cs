// See https://aka.ms/new-console-template for more information
using SCS;
using SCS.Commands;
using SCS.FoldersAndFiles;
using SCS.Review;
using SCS.SCS;


UserInvoker userInvoker = new UserInvoker();
SCSReciever scsReciever= SCSReciever.GetSystem();
ConsoleSubscriber subscriber = new ConsoleSubscriber();

Files homePage = new();
Files loginPage = new();
Files payMent = new();
Files cartPage = new();
Files aboutPage = new();
Folder imgFolder = new (); 
Files img1 =new();
Files img2 = new();
Files img3 = new();
Files img4 = new();
imgFolder.Add (img1);
imgFolder.Add (img2);
imgFolder.Add (img3);
imgFolder.Add (img4);
Folder reactProject=new Folder();
reactProject.Add(homePage);
reactProject.Add(loginPage);
reactProject.Add(payMent);
reactProject.Add(cartPage);
reactProject.Add(aboutPage);
reactProject.Add(imgFolder);

userInvoker.SCSCommandRequest(new Add(reactProject));
userInvoker.SCSCommandRequest (new Commit(reactProject));
userInvoker.DoJob();
userInvoker.DoJob();
scsReciever.Subscribe(subscriber);
userInvoker.SCSCommandRequest(new RequestTheReview(reactProject));
userInvoker.DoJob();
userInvoker.SCSCommandRequest(new Merge(reactProject));
userInvoker.DoJob();