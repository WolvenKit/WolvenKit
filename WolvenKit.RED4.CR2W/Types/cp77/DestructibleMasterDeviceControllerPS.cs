using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructibleMasterDeviceControllerPS : MasterControllerPS
	{
		private CBool _isDestroyed;

		[Ordinal(105)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetProperty(ref _isDestroyed);
			set => SetProperty(ref _isDestroyed, value);
		}

		public DestructibleMasterDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
