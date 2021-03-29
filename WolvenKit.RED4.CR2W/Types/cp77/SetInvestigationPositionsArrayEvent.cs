using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetInvestigationPositionsArrayEvent : redEvent
	{
		private CArray<Vector4> _investigationPositionsArray;

		[Ordinal(0)] 
		[RED("investigationPositionsArray")] 
		public CArray<Vector4> InvestigationPositionsArray
		{
			get => GetProperty(ref _investigationPositionsArray);
			set => SetProperty(ref _investigationPositionsArray, value);
		}

		public SetInvestigationPositionsArrayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
