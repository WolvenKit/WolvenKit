using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDefaultMixingSignposts : audioAudioMetadata
	{
		private CName _endOfCombat;
		private CName _inCombat;
		private CName _inStealth;
		private CName _aiAlerted;
		private CName _sceneBootstrapSignpost;
		private CArray<CName> _reservedSignposts;

		[Ordinal(1)] 
		[RED("endOfCombat")] 
		public CName EndOfCombat
		{
			get => GetProperty(ref _endOfCombat);
			set => SetProperty(ref _endOfCombat, value);
		}

		[Ordinal(2)] 
		[RED("inCombat")] 
		public CName InCombat
		{
			get => GetProperty(ref _inCombat);
			set => SetProperty(ref _inCombat, value);
		}

		[Ordinal(3)] 
		[RED("inStealth")] 
		public CName InStealth
		{
			get => GetProperty(ref _inStealth);
			set => SetProperty(ref _inStealth, value);
		}

		[Ordinal(4)] 
		[RED("aiAlerted")] 
		public CName AiAlerted
		{
			get => GetProperty(ref _aiAlerted);
			set => SetProperty(ref _aiAlerted, value);
		}

		[Ordinal(5)] 
		[RED("sceneBootstrapSignpost")] 
		public CName SceneBootstrapSignpost
		{
			get => GetProperty(ref _sceneBootstrapSignpost);
			set => SetProperty(ref _sceneBootstrapSignpost, value);
		}

		[Ordinal(6)] 
		[RED("reservedSignposts")] 
		public CArray<CName> ReservedSignposts
		{
			get => GetProperty(ref _reservedSignposts);
			set => SetProperty(ref _reservedSignposts, value);
		}

		public audioDefaultMixingSignposts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
