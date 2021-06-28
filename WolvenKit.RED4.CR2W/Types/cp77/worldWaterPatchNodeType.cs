using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWaterPatchNodeType : CVariable
	{
		private CName _typeName;

		[Ordinal(0)] 
		[RED("typeName")] 
		public CName TypeName
		{
			get => GetProperty(ref _typeName);
			set => SetProperty(ref _typeName, value);
		}

		public worldWaterPatchNodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
