using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameStateAdvanced : IScriptable
	{
		private CName _opertyMaxScore;
		private CName _opertyCurrentLives;
		private CName _opertyCurrentScore;
		private gameuiGameStatePropertyChangedCallback _propertyChanged;

		[Ordinal(0)] 
		[RED("opertyMaxScore")] 
		public CName OpertyMaxScore
		{
			get => GetProperty(ref _opertyMaxScore);
			set => SetProperty(ref _opertyMaxScore, value);
		}

		[Ordinal(1)] 
		[RED("opertyCurrentLives")] 
		public CName OpertyCurrentLives
		{
			get => GetProperty(ref _opertyCurrentLives);
			set => SetProperty(ref _opertyCurrentLives, value);
		}

		[Ordinal(2)] 
		[RED("opertyCurrentScore")] 
		public CName OpertyCurrentScore
		{
			get => GetProperty(ref _opertyCurrentScore);
			set => SetProperty(ref _opertyCurrentScore, value);
		}

		[Ordinal(3)] 
		[RED("PropertyChanged")] 
		public gameuiGameStatePropertyChangedCallback PropertyChanged_
		{
			get => GetProperty(ref _propertyChanged);
			set => SetProperty(ref _propertyChanged, value);
		}

		public gameuiSideScrollerMiniGameStateAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
