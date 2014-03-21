ChangeEmailViewModel Class
==========================
Holds data for the ChangeEmail view.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.ViewModels.BaseViewModel][2]  
    [MvcAccount.ViewModels.FormViewModel][3]&lt;[ChangeEmailInput][4]>  
      **MvcAccount.ViewModels.ChangeEmailViewModel**  

**Namespace:** [MvcAccount.ViewModels][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class ChangeEmailViewModel : FormViewModel<ChangeEmailInput>
```

The **ChangeEmailViewModel** type exposes the following members.


Constructors
------------

Name                      | Description                                                                                      
------------------------- | ------------------------------------------------------------------------------------------------ 
[ChangeEmailViewModel][6] | Initializes a new instance of the **ChangeEmailViewModel** class using the provided input model. 


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][7]           | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][8]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][9]      | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][10]         | Gets the [Type][11] of the current instance. (Inherited from [Object][1].)                                                                                 
[MemberwiseClone][12] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToString][13]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name             | Description                                                                           
---------------- | ------------------------------------------------------------------------------------- 
[InputModel][14] | The form's input model. (Inherited from [FormViewModel<TInputModel>][3].)             
[SubmitText][15] | Text for the submit button. (Inherited from [FormViewModel<TInputModel>][3].)         
[Title][16]      | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].) 
[Url][17]        | A [UrlHelper][18] for creating URLs. (Inherited from [BaseViewModel][2].)             


See Also
--------
[MvcAccount.ViewModels Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../BaseViewModel/README.md
[3]: ../FormViewModel_1/README.md
[4]: ../../MvcAccount/ChangeEmailInput/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[8]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[9]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[10]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[11]: http://msdn.microsoft.com/en-us/library/42892f65
[12]: http://msdn.microsoft.com/en-us/library/57ctke0a
[13]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[14]: ../FormViewModel_1/InputModel.md
[15]: ../FormViewModel_1/SubmitText.md
[16]: ../BaseViewModel/Title.md
[17]: ../BaseViewModel/Url.md
[18]: http://msdn.microsoft.com/en-us/library/dd492578