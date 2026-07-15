# Red Type Template Service

The Red Type Template Service is the core of the templatating system in WolvenKit. It handles the management of templates, including reading and validating files on the disk as well as read and write access from the program.

## Usage

**Instanciation**

To instanciate the service only the ILoggerService is required, alongside the path to the user and system template folders.
Templates are indexed on class creation and a rescan can be triggered via the `LoadTemplates` method at any time.

:::info
Note that only files in the root of the template folders are indexed. This is to allow the OS to handle the enforcing of unique file names.
:::

**Reading**

To read a specific indexed template, use the `ReadTemplate` method. This will return a `RedTemplate` object which contains the metadata (author, version and description) as well as the templated data.
If no template is found, `null` is returned.

If instead you want to create a guaranteed instance of a class from information about a template, use the `CreateTypeInstance` method. <br>
This methods will always return an instance of the type. In case the requested template does not exist it will try to read the "default" template of the same type and source, if it is not available a new instance of the type will be created using `RedTypeManager.CreateAndInitRedType`.

**Writing**

Creation of a new template is handled by the `WriteTemplate` method. It expects a `RedTemplate` object as input where the `Data` property is not null and contains a templatable type, alongside a template name and destination.

:::warning
`WriteTemplate` always overwrite existing templates, to check whether a template already exists use the `TemplateExists` method.
:::

:::info
Checking whether a type is templatable is done using the `IsTypeTemplatable` method. <br>
Templatable types are types which are assignable to `IRedType`, are non abstract and non primitive and don't inherit from `IRedPrimitive`.
:::

Templates can be deleted using the `DeleteTemplate` method.

:::warning
For usage within the WolvenKit project modifying the system templates is not allowed, though not enforced by code.
This is due to system templates being pulled from the `WolvenKit/Wolvenkit-Resources` repository
:::

**Miscellaneous**

A template descriptor containing the file path and name can be aquired from the `GetTemplateDescriptor` method or by directly querying the `SystemTemplates` and `UserTemplates` lists. <br>
In situations where the template is chosen in a different place than it is resolved this can be useful in combination with `IsOnlyNoneOrDefaultAvailable` to auto select a template and avoid unnecessary user interaction.

The implementation of `ParseType` in this class is lazily cached and as such quicker than indexing the domain assembly and their types every time.

All methods are thread safe.

Most methods have several overloads, e.g. accepting the type as a generic as well as a parameter, or a `RedTypeTemplateDescriptor`. <br>
Many parameters are optional, for example when reading, the name defaults to "default" and source to Auto, when writing only the destination is defaulted to User.

## Design

Templates when stored are plain json files containing a serialized `RedTypeTemplate` where the name and type are primarily encoded in it's filename which follows the `NAME.TYPE.json` pattern. <br>
When templates are loaded a descriptor is created for each template that contains it's name, type and backing filepath. It is only deserialized during the `LoadTemplates` method to validate that it does not contain malformed data as this is a good place to communicate any issues with the user. <br>
In addition catching most malformed templates early means there is less of a chance for unexpected template resolution when reading templates where a template is indexed but cannot be read.

Template files are ultimately read at the time of reading the template using either `ReadTemplate` or `CreateTypeInstance`. This lowers the memory footprint of the service as it only needs to keep track of the descriptors rather than the entire payload.


