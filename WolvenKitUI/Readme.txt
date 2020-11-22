Orchestra.Shell.Ribbon.Fluent project template readme
================================================================================================

Congratulations with creating a new Orchestra project:

WolvenKitUI


================================================================================================
IMPORTANT NOTES !!! READ THIS !!! READ THIS !!! READ THIS !!! READ THIS !!! READ THIS !!!
================================================================================================

------------------------------------------------------------------------------------------------
1. MsBuildSdkExtras
------------------------------------------------------------------------------------------------

This project template uses MsBuildSdkExtras (see https://github.com/onovotny/MSBuildSdkExtras) with 
a fixed value inside the csproj itself (otherwise the project template system will error). You can 
define a solution-wide version of this library by adding a file named `global.json` in the same 
directory as the `.sln` with the following content: 

{
    "msbuild-sdks": {
        "MSBuild.Sdk.Extras": "2.0.54"
    }
}


------------------------------------------------------------------------------------------------
2. Fody
------------------------------------------------------------------------------------------------

This project template includes Fody and some weavers (Catel.Fody, ModuleInit.Fody and Obsolete.Fody)
by default.

If you don't want Fody to be included in the project, follow these steps:

1. Remove the PackageReference elements that include 'Fody' in the csproj file
2. Remove `FodyWeavers.xml`
3. Remove `ModuleInitializer.cs`


------------------------------------------------------------------------------------------------
3. Repository Template
------------------------------------------------------------------------------------------------

This template is designed to work with RepositoryTemplate (see https://github.com/geertvanhorrik/repositorytemplate).

This repository template allows any user to keep the generic deployment / solution files in sync with the
latest standards and allows for easy packaging and deployment.

The generated project file contains fallback values in case the repository template cannot be found
in order to make sure the initially created project compiles.


------------------------------------------------------------------------------------------------
4. Catel version 5.x or higher
------------------------------------------------------------------------------------------------

Note that this project template assumes that you are using Catel 5.x.


For more information and support, visit https://www.catelproject.com


================================================================================================
Other interesting notes in this document
================================================================================================

1. Automatically transforming regular properties to Catel properties
2. Orchestra & Orc components

------------------------------------------------------------------------------------------------
1. Automatically transforming regular properties to Catel properties
------------------------------------------------------------------------------------------------

To automatically transform a regular property into a Catel property, use
the following NuGet package:

* Catel.Fody

The following property definition:


    public string Name { get; set; }


will be weaved into:


    public string Name
    {
        get { return GetValue<string>(NameProperty); }
        set { SetValue(NameProperty, value); }
    }
     
    public static readonly PropertyData NameProperty = RegisterProperty("Name", typeof(string));

    
For more information, visit https://www.catelproject.com/tools/catel-fody/


------------------------------------------------------------------------------------------------
3. Orchestra & Orc components
------------------------------------------------------------------------------------------------

If you are planning on using WPF, there is a huge set (60+) of free open-source components 
available based on Catel. All these open source are developed by a company called WildGums 
(see https://www.wildgums.com) and provided to the community for free. The components are well 
maintained and being used in several commercial WPF applications.

For more information, see https://github.com/wildgums
