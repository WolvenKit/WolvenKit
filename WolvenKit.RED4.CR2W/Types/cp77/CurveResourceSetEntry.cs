using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurveResourceSetEntry : CVariable
	{
		private CName _name;
		private rRef<CurveSet> _curveResRef;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("curveResRef")] 
		public rRef<CurveSet> CurveResRef
		{
			get => GetProperty(ref _curveResRef);
			set => SetProperty(ref _curveResRef, value);
		}

		public CurveResourceSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
