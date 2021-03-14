using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshRawClothData : CVariable
	{
		private physicsclothState _state;
		private CArray<DataBuffer> _maxDistanceChannel;
		private CArray<DataBuffer> _maxDistanceExtChannel;
		private CArray<DataBuffer> _backstopDistanceChannel;
		private CArray<DataBuffer> _backstopRadiusChannel;
		private CArray<DataBuffer> _selfCollisionChannel;

		[Ordinal(0)] 
		[RED("state")] 
		public physicsclothState State
		{
			get
			{
				if (_state == null)
				{
					_state = (physicsclothState) CR2WTypeManager.Create("physicsclothState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxDistanceChannel")] 
		public CArray<DataBuffer> MaxDistanceChannel
		{
			get
			{
				if (_maxDistanceChannel == null)
				{
					_maxDistanceChannel = (CArray<DataBuffer>) CR2WTypeManager.Create("array:DataBuffer", "maxDistanceChannel", cr2w, this);
				}
				return _maxDistanceChannel;
			}
			set
			{
				if (_maxDistanceChannel == value)
				{
					return;
				}
				_maxDistanceChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxDistanceExtChannel")] 
		public CArray<DataBuffer> MaxDistanceExtChannel
		{
			get
			{
				if (_maxDistanceExtChannel == null)
				{
					_maxDistanceExtChannel = (CArray<DataBuffer>) CR2WTypeManager.Create("array:DataBuffer", "maxDistanceExtChannel", cr2w, this);
				}
				return _maxDistanceExtChannel;
			}
			set
			{
				if (_maxDistanceExtChannel == value)
				{
					return;
				}
				_maxDistanceExtChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("backstopDistanceChannel")] 
		public CArray<DataBuffer> BackstopDistanceChannel
		{
			get
			{
				if (_backstopDistanceChannel == null)
				{
					_backstopDistanceChannel = (CArray<DataBuffer>) CR2WTypeManager.Create("array:DataBuffer", "backstopDistanceChannel", cr2w, this);
				}
				return _backstopDistanceChannel;
			}
			set
			{
				if (_backstopDistanceChannel == value)
				{
					return;
				}
				_backstopDistanceChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("backstopRadiusChannel")] 
		public CArray<DataBuffer> BackstopRadiusChannel
		{
			get
			{
				if (_backstopRadiusChannel == null)
				{
					_backstopRadiusChannel = (CArray<DataBuffer>) CR2WTypeManager.Create("array:DataBuffer", "backstopRadiusChannel", cr2w, this);
				}
				return _backstopRadiusChannel;
			}
			set
			{
				if (_backstopRadiusChannel == value)
				{
					return;
				}
				_backstopRadiusChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("selfCollisionChannel")] 
		public CArray<DataBuffer> SelfCollisionChannel
		{
			get
			{
				if (_selfCollisionChannel == null)
				{
					_selfCollisionChannel = (CArray<DataBuffer>) CR2WTypeManager.Create("array:DataBuffer", "selfCollisionChannel", cr2w, this);
				}
				return _selfCollisionChannel;
			}
			set
			{
				if (_selfCollisionChannel == value)
				{
					return;
				}
				_selfCollisionChannel = value;
				PropertySet(this);
			}
		}

		public meshRawClothData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
