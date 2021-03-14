using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepsMetadata : audioAudioMetadata
	{
		private CName _defaultFootwearMetadata;
		private CArray<CName> _footwearMetadataArray;
		private CName _slideEvent;
		private CName _onEnterSound;
		private CName _onExitSound;

		[Ordinal(1)] 
		[RED("defaultFootwearMetadata")] 
		public CName DefaultFootwearMetadata
		{
			get
			{
				if (_defaultFootwearMetadata == null)
				{
					_defaultFootwearMetadata = (CName) CR2WTypeManager.Create("CName", "defaultFootwearMetadata", cr2w, this);
				}
				return _defaultFootwearMetadata;
			}
			set
			{
				if (_defaultFootwearMetadata == value)
				{
					return;
				}
				_defaultFootwearMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("footwearMetadataArray")] 
		public CArray<CName> FootwearMetadataArray
		{
			get
			{
				if (_footwearMetadataArray == null)
				{
					_footwearMetadataArray = (CArray<CName>) CR2WTypeManager.Create("array:CName", "footwearMetadataArray", cr2w, this);
				}
				return _footwearMetadataArray;
			}
			set
			{
				if (_footwearMetadataArray == value)
				{
					return;
				}
				_footwearMetadataArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slideEvent")] 
		public CName SlideEvent
		{
			get
			{
				if (_slideEvent == null)
				{
					_slideEvent = (CName) CR2WTypeManager.Create("CName", "slideEvent", cr2w, this);
				}
				return _slideEvent;
			}
			set
			{
				if (_slideEvent == value)
				{
					return;
				}
				_slideEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("onEnterSound")] 
		public CName OnEnterSound
		{
			get
			{
				if (_onEnterSound == null)
				{
					_onEnterSound = (CName) CR2WTypeManager.Create("CName", "onEnterSound", cr2w, this);
				}
				return _onEnterSound;
			}
			set
			{
				if (_onEnterSound == value)
				{
					return;
				}
				_onEnterSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("onExitSound")] 
		public CName OnExitSound
		{
			get
			{
				if (_onExitSound == null)
				{
					_onExitSound = (CName) CR2WTypeManager.Create("CName", "onExitSound", cr2w, this);
				}
				return _onExitSound;
			}
			set
			{
				if (_onExitSound == value)
				{
					return;
				}
				_onExitSound = value;
				PropertySet(this);
			}
		}

		public audioFootstepsMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
