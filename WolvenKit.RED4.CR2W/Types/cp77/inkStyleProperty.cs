using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleProperty : CVariable
	{
		private CName _propertyPath;
		private CVariant _value;

		[Ordinal(0)] 
		[RED("propertyPath")] 
		public CName PropertyPath
		{
			get => GetProperty(ref _propertyPath);
			set => SetProperty(ref _propertyPath, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public inkStyleProperty(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
