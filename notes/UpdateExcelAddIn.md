# Excel Add-in Migration Guide

This guide provides instructions for migrating from the old Excel add-in to the new one. Follow the steps carefully to ensure a smooth transition.

---

## Uninstalling the Old Add-in (for desktop version)

1. Open **Excel**.
2. Navigate to **File** → **Options** → **Add-ins**.
3. At the bottom of the window, locate the **Manage** dropdown menu.
4. Select **Excel Add-ins** and click **Go**.
5. In the new window, uncheck **Xmlrpc** to deactivate the old add-in.

---

## Installing the New Add-in

### For Excel Web
1. Open Excel in your web browser.
2. Navigate to **Home** → **Add-ins** → **[+] More Add-ins**.
3. Select **MY ADD-INS** → **Upload My Add-in**.
4. Upload the `manifest.xml` file to activate the new add-in.

### For Excel Desktop
1. Open **Excel Desktop**.
2. Navigate to **File** → **Options** → **Trust Center** → **Trust Center Settings...** → **Trusted Add-in Catalogs**.
3. In the **Catalog URL** field, enter the network path to the folder containing the `manifest.xml` file.  
   Example: `\\localhost\C$\Users\<user>\Documents\SIHOT-Add-in`.
4. Restart Excel to apply the changes.

---

## Migrating Functions
The new add-in is located on the Home tab next to the Add-Ins button.

1. If the file you open in Excel contains references to the old add-in, a pop-up will appear in the sidebar asking if you want to migrate the functions to the new add-in.
2. Configure the new add-in in the sidebar or load a previously saved configuration to restore functionality.

---

After completing these steps, the new add-in should be fully operational, and all previously configured functions will work as expected.
