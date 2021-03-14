using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioBulletImpactSettings : audioEntitySettings
	{
		private CName _lowImpactSound;
		private CName _medImpactSound;
		private CName _hiImpactSound;
		private CName _critImpactSound;
		private CName _npcImpactSound;
		private CFloat _mediumDamageDistance;
		private CFloat _highDamageDistance;

		[Ordinal(6)] 
		[RED("lowImpactSound")] 
		public CName LowImpactSound
		{
			get
			{
				if (_lowImpactSound == null)
				{
					_lowImpactSound = (CName) CR2WTypeManager.Create("CName", "lowImpactSound", cr2w, this);
				}
				return _lowImpactSound;
			}
			set
			{
				if (_lowImpactSound == value)
				{
					return;
				}
				_lowImpactSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("medImpactSound")] 
		public CName MedImpactSound
		{
			get
			{
				if (_medImpactSound == null)
				{
					_medImpactSound = (CName) CR2WTypeManager.Create("CName", "medImpactSound", cr2w, this);
				}
				return _medImpactSound;
			}
			set
			{
				if (_medImpactSound == value)
				{
					return;
				}
				_medImpactSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hiImpactSound")] 
		public CName HiImpactSound
		{
			get
			{
				if (_hiImpactSound == null)
				{
					_hiImpactSound = (CName) CR2WTypeManager.Create("CName", "hiImpactSound", cr2w, this);
				}
				return _hiImpactSound;
			}
			set
			{
				if (_hiImpactSound == value)
				{
					return;
				}
				_hiImpactSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("critImpactSound")] 
		public CName CritImpactSound
		{
			get
			{
				if (_critImpactSound == null)
				{
					_critImpactSound = (CName) CR2WTypeManager.Create("CName", "critImpactSound", cr2w, this);
				}
				return _critImpactSound;
			}
			set
			{
				if (_critImpactSound == value)
				{
					return;
				}
				_critImpactSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("npcImpactSound")] 
		public CName NpcImpactSound
		{
			get
			{
				if (_npcImpactSound == null)
				{
					_npcImpactSound = (CName) CR2WTypeManager.Create("CName", "npcImpactSound", cr2w, this);
				}
				return _npcImpactSound;
			}
			set
			{
				if (_npcImpactSound == value)
				{
					return;
				}
				_npcImpactSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("mediumDamageDistance")] 
		public CFloat MediumDamageDistance
		{
			get
			{
				if (_mediumDamageDistance == null)
				{
					_mediumDamageDistance = (CFloat) CR2WTypeManager.Create("Float", "mediumDamageDistance", cr2w, this);
				}
				return _mediumDamageDistance;
			}
			set
			{
				if (_mediumDamageDistance == value)
				{
					return;
				}
				_mediumDamageDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("highDamageDistance")] 
		public CFloat HighDamageDistance
		{
			get
			{
				if (_highDamageDistance == null)
				{
					_highDamageDistance = (CFloat) CR2WTypeManager.Create("Float", "highDamageDistance", cr2w, this);
				}
				return _highDamageDistance;
			}
			set
			{
				if (_highDamageDistance == value)
				{
					return;
				}
				_highDamageDistance = value;
				PropertySet(this);
			}
		}

		public audioBulletImpactSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
