using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudMilitechWarningGameController : gameuiHUDGameController
	{
		private wCHandle<inkCompoundWidget> _root;
		private CHandle<inkanimProxy> _anim;
		private CUInt32 _factListenerId;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		[Ordinal(11)] 
		[RED("factListenerId")] 
		public CUInt32 FactListenerId
		{
			get => GetProperty(ref _factListenerId);
			set => SetProperty(ref _factListenerId, value);
		}

		public hudMilitechWarningGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
