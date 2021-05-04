using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VisualRecord : CVariable
	{
		private CArray<CUInt32> _layerIDs;
		private wCHandle<ScriptedPuppet> _puppet;
		private CBool _infiniteDuration;
		private CFloat _showDuration;

		[Ordinal(0)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get => GetProperty(ref _layerIDs);
			set => SetProperty(ref _layerIDs, value);
		}

		[Ordinal(1)] 
		[RED("puppet")] 
		public wCHandle<ScriptedPuppet> Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(2)] 
		[RED("infiniteDuration")] 
		public CBool InfiniteDuration
		{
			get => GetProperty(ref _infiniteDuration);
			set => SetProperty(ref _infiniteDuration, value);
		}

		[Ordinal(3)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get => GetProperty(ref _showDuration);
			set => SetProperty(ref _showDuration, value);
		}

		public DEBUG_VisualRecord(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
