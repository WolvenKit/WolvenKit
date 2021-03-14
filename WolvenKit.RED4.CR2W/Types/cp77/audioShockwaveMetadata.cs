using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioShockwaveMetadata : audioEmitterMetadata
	{
		private CName _explosionMetadataName;
		private CName _thumpMetadataName;
		private CName _electroshockMetadataName;
		private CName _revealMetadataName;

		[Ordinal(1)] 
		[RED("explosionMetadataName")] 
		public CName ExplosionMetadataName
		{
			get
			{
				if (_explosionMetadataName == null)
				{
					_explosionMetadataName = (CName) CR2WTypeManager.Create("CName", "explosionMetadataName", cr2w, this);
				}
				return _explosionMetadataName;
			}
			set
			{
				if (_explosionMetadataName == value)
				{
					return;
				}
				_explosionMetadataName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("thumpMetadataName")] 
		public CName ThumpMetadataName
		{
			get
			{
				if (_thumpMetadataName == null)
				{
					_thumpMetadataName = (CName) CR2WTypeManager.Create("CName", "thumpMetadataName", cr2w, this);
				}
				return _thumpMetadataName;
			}
			set
			{
				if (_thumpMetadataName == value)
				{
					return;
				}
				_thumpMetadataName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("electroshockMetadataName")] 
		public CName ElectroshockMetadataName
		{
			get
			{
				if (_electroshockMetadataName == null)
				{
					_electroshockMetadataName = (CName) CR2WTypeManager.Create("CName", "electroshockMetadataName", cr2w, this);
				}
				return _electroshockMetadataName;
			}
			set
			{
				if (_electroshockMetadataName == value)
				{
					return;
				}
				_electroshockMetadataName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("revealMetadataName")] 
		public CName RevealMetadataName
		{
			get
			{
				if (_revealMetadataName == null)
				{
					_revealMetadataName = (CName) CR2WTypeManager.Create("CName", "revealMetadataName", cr2w, this);
				}
				return _revealMetadataName;
			}
			set
			{
				if (_revealMetadataName == value)
				{
					return;
				}
				_revealMetadataName = value;
				PropertySet(this);
			}
		}

		public audioShockwaveMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
