using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterLinkedCluekRequest : gameScriptableSystemRequest
	{
		private LinkedFocusClueData _linkedCluekData;
		private CBool _forceUpdate;

		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetProperty(ref _linkedCluekData);
			set => SetProperty(ref _linkedCluekData, value);
		}

		[Ordinal(1)] 
		[RED("forceUpdate")] 
		public CBool ForceUpdate
		{
			get => GetProperty(ref _forceUpdate);
			set => SetProperty(ref _forceUpdate, value);
		}

		public RegisterLinkedCluekRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
