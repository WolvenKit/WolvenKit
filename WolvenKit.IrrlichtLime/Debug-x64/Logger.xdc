<?xml version="1.0"?><doc>
<members>
<member name="T:IrrlichtLime.Logger" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="12">
<summary>
Logging messages, warnings and errors.
</summary>
</member>
<member name="M:IrrlichtLime.Logger.Log(System.String,System.String,IrrlichtLime.LogLevel)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="19">
<summary>
Prints out a text into the log.
</summary>
<param name="text">Text to print out.</param>
<param name="hint">Additional info. This string is added after a " :" to the string.</param>
<param name="level">Log level of the text. Default is <see cref="F:IrrlichtLime.LogLevel.Information"/>.</param>
</member>
<member name="M:IrrlichtLime.Logger.Log(System.String,IrrlichtLime.LogLevel)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="27">
<summary>
Prints out a text into the log.
</summary>
<param name="text">Text to print out.</param>
<param name="level">Log level of the text. Default is <see cref="F:IrrlichtLime.LogLevel.Information"/>.</param>
</member>
<member name="M:IrrlichtLime.Logger.Log(System.String)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="34">
<summary>
Prints out a text into the log.
</summary>
<param name="text">Text to print out.</param>
</member>
<member name="P:IrrlichtLime.Logger.LogLevel" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="40">
<summary>
Current log level.
With this value, texts which are sent to the logger are filtered out.
For example setting this value to <see cref="F:IrrlichtLime.LogLevel.Warning"/>, only warnings and errors are printed out.
Setting it to <see cref="F:IrrlichtLime.LogLevel.Information"/>, which is the default setting, warnings, errors and informational texts are printed out.
</summary>
</member>
</members>
</doc>