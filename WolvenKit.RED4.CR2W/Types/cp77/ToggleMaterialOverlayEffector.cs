using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleMaterialOverlayEffector : gameEffector
	{
		private CString _effectPath;
		private CName _effectTag;
		private CHandle<gameEffectInstance> _effectInstance;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("effectPath")] 
		public CString EffectPath
		{
			get => GetProperty(ref _effectPath);
			set => SetProperty(ref _effectPath, value);
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetProperty(ref _effectTag);
			set => SetProperty(ref _effectTag, value);
		}

		[Ordinal(2)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetProperty(ref _effectInstance);
			set => SetProperty(ref _effectInstance, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public ToggleMaterialOverlayEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
