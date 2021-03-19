using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableEnum : LibTreeDefTreeVariable
	{
		private CBool _exportAsProperty;
		private CName _enumClass;
		private CInt64 _defaultValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get => GetProperty(ref _exportAsProperty);
			set => SetProperty(ref _exportAsProperty, value);
		}

		[Ordinal(3)] 
		[RED("enumClass")] 
		public CName EnumClass
		{
			get => GetProperty(ref _enumClass);
			set => SetProperty(ref _enumClass, value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CInt64 DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public LibTreeDefTreeVariableEnum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
