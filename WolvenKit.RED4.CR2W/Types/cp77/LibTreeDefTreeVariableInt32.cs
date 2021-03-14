using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableInt32 : LibTreeDefTreeVariable
	{
		private CBool _exportAsProperty;
		private CInt32 _defaultValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get
			{
				if (_exportAsProperty == null)
				{
					_exportAsProperty = (CBool) CR2WTypeManager.Create("Bool", "exportAsProperty", cr2w, this);
				}
				return _exportAsProperty;
			}
			set
			{
				if (_exportAsProperty == value)
				{
					return;
				}
				_exportAsProperty = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("defaultValue")] 
		public CInt32 DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CInt32) CR2WTypeManager.Create("Int32", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		public LibTreeDefTreeVariableInt32(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
