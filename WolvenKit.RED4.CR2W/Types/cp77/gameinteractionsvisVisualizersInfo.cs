using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisVisualizersInfo : CVariable
	{
		private CInt32 _activeVisId;
		private CArray<CInt32> _visIds;

		[Ordinal(0)] 
		[RED("activeVisId")] 
		public CInt32 ActiveVisId
		{
			get => GetProperty(ref _activeVisId);
			set => SetProperty(ref _activeVisId, value);
		}

		[Ordinal(1)] 
		[RED("visIds")] 
		public CArray<CInt32> VisIds
		{
			get => GetProperty(ref _visIds);
			set => SetProperty(ref _visIds, value);
		}

		public gameinteractionsvisVisualizersInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
