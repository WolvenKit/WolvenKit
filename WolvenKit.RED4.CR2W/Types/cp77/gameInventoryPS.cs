using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventoryPS : gameComponentPS
	{
		private CBool _isRegisteredShared;
		private CBool _accessible;

		[Ordinal(0)] 
		[RED("isRegisteredShared")] 
		public CBool IsRegisteredShared
		{
			get => GetProperty(ref _isRegisteredShared);
			set => SetProperty(ref _isRegisteredShared, value);
		}

		[Ordinal(1)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get => GetProperty(ref _accessible);
			set => SetProperty(ref _accessible, value);
		}

		public gameInventoryPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
