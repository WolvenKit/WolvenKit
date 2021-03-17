using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpGameplayLightComponent : entLightComponent
	{
		private CBool _reactToTime;
		private GameTime _begin;
		private GameTime _end;
		private CFloat _probability;
		private GameTime _delayRange;

		[Ordinal(54)] 
		[RED("reactToTime")] 
		public CBool ReactToTime
		{
			get => GetProperty(ref _reactToTime);
			set => SetProperty(ref _reactToTime, value);
		}

		[Ordinal(55)] 
		[RED("begin")] 
		public GameTime Begin
		{
			get => GetProperty(ref _begin);
			set => SetProperty(ref _begin, value);
		}

		[Ordinal(56)] 
		[RED("end")] 
		public GameTime End
		{
			get => GetProperty(ref _end);
			set => SetProperty(ref _end, value);
		}

		[Ordinal(57)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		[Ordinal(58)] 
		[RED("delayRange")] 
		public GameTime DelayRange
		{
			get => GetProperty(ref _delayRange);
			set => SetProperty(ref _delayRange, value);
		}

		public cpGameplayLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
