using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpPlayerDetector_PseudoDevice : gameObject
	{
		private NodeRef _playerDetector;

		[Ordinal(40)] 
		[RED("playerDetector")] 
		public NodeRef PlayerDetector
		{
			get => GetProperty(ref _playerDetector);
			set => SetProperty(ref _playerDetector, value);
		}

		public cpPlayerDetector_PseudoDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
