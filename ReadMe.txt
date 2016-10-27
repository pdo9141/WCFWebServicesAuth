https://msdn.microsoft.com/library/ff406125.aspx

For this scenario, you need to enable basic authentication in IIS. Select Control Panel from the Windows Start menu. In the Control Panel window, 
select Programs. In In the Windows Explorer window that appears, click the Turn Windows features on and off link to display the Windows Features dialog box.
Expand the Internet Information Services node. Then expand the World Wide Web Services node. Next, expand the Security node and check 
Basic Authentication. Click OK to close the dialog box.

When you create the Web site to host the WCF service, you will use HTTPS and SSL to encrypt communications. SSL requires a digital certificate, 
so you must next create and specify a certificate to use. Select Control Panel | Administrative Tools from the Windows Start menu. If you have not configured the 
Start menu to display Administrative Tools, open the Control Panel, click Classic View and then click on Administrative Tools. In the Windows Explorer window that appears, 
double-click the Internet Information Services (IIS) Manager shortcut to display the IIS Manager applet.
First, ensure the Web server is set up for basic authentication. In the Connections pane, expand the Sites node. Select Default Web Site. Double-click Authentication 
in the IIS section to display the Authentication page. Confirm that Basic Authentication has a status of Enabled. If it does not, right-click Basic Authentication 
and select Enable.

Next you will create a certificate. In the Connections pane, select the top node (the node with the name of your computer. Double-click Server Certificates in 
the IIS section to display the Server Certificates page. In the Actions pane, select Create Self-Signed Certificate to display the Create Self-Signed Certificate 
dialog box. Name the cerificate WCFSecurityTutorial (see Figure 3). Click OK to close the dialog box. You should see the certificate listed in the Server 
Certificates page.

In a production environment, you should not use a self-signed certificate. You should use a certificate from your organization or a trusted third party. 
You should only use a self-signed certificate for development and testing purposes on your own computer.
Next, you need to configure IIS to enable Web sites to communicate using SSL and the certificate you just created. In the Connections pane, right-click Default 
Web Site and select Edit Bindings to display the Site Bindings dialog box. Click Add to display the Add Site Binding dialog box. Select https from the 
Type drop-down list. Next, select the WCFSecurityTutorial from the SSL certificate drop-down list.

Changing the Identity from ApplicationPoolIdentity to LocalSystem did the work in IIS if you have permissions issue with web.config

Don't use localhost when adding the service reference, use cert issued to name (WayTooAwesome in my case)

In the app.config file, add <transport clientCredentialType="Basic"></transport>