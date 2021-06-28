using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Knife : BaseProjectile
	{
		private CBool _collided;

		[Ordinal(51)] 
		[RED("collided")] 
		public CBool Collided
		{
			get => GetProperty(ref _collided);
			set => SetProperty(ref _collided, value);
		}

		public Knife(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
