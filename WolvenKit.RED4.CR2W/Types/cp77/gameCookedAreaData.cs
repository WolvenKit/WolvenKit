using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedAreaData : CVariable
	{
		private entEntityID _entityID;
		private Vector3 _position;
		private CFloat _radius;
		private CHandle<gamemappinsIMappinVolume> _volume;

		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(3)] 
		[RED("volume")] 
		public CHandle<gamemappinsIMappinVolume> Volume
		{
			get => GetProperty(ref _volume);
			set => SetProperty(ref _volume, value);
		}

		public gameCookedAreaData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
