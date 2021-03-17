using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAddInputGroupEvent : redEvent
	{
		private CName _groupId;
		private gameuiInputHintGroupData _data;
		private CName _targetHintContainer;

		[Ordinal(0)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get => GetProperty(ref _groupId);
			set => SetProperty(ref _groupId, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public gameuiInputHintGroupData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get => GetProperty(ref _targetHintContainer);
			set => SetProperty(ref _targetHintContainer, value);
		}

		public gameuiAddInputGroupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
