using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlayerInVehicleASTCD : audioAudioStateTransitionConditionData
	{
		private CBool _isInside;

		[Ordinal(1)] 
		[RED("isInside")] 
		public CBool IsInside
		{
			get => GetProperty(ref _isInside);
			set => SetProperty(ref _isInside, value);
		}

		public audioPlayerInVehicleASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
