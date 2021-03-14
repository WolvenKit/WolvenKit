using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioShockwaveGlobalSettings : audioAudioMetadata
	{
		private CFloat _explosionPropagationSpeed;
		private CFloat _thumpPropagationSpeed;
		private CFloat _electroshockPropagationSpeed;
		private CFloat _revealPropagationSpeed;

		[Ordinal(1)] 
		[RED("explosionPropagationSpeed")] 
		public CFloat ExplosionPropagationSpeed
		{
			get
			{
				if (_explosionPropagationSpeed == null)
				{
					_explosionPropagationSpeed = (CFloat) CR2WTypeManager.Create("Float", "explosionPropagationSpeed", cr2w, this);
				}
				return _explosionPropagationSpeed;
			}
			set
			{
				if (_explosionPropagationSpeed == value)
				{
					return;
				}
				_explosionPropagationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("thumpPropagationSpeed")] 
		public CFloat ThumpPropagationSpeed
		{
			get
			{
				if (_thumpPropagationSpeed == null)
				{
					_thumpPropagationSpeed = (CFloat) CR2WTypeManager.Create("Float", "thumpPropagationSpeed", cr2w, this);
				}
				return _thumpPropagationSpeed;
			}
			set
			{
				if (_thumpPropagationSpeed == value)
				{
					return;
				}
				_thumpPropagationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("electroshockPropagationSpeed")] 
		public CFloat ElectroshockPropagationSpeed
		{
			get
			{
				if (_electroshockPropagationSpeed == null)
				{
					_electroshockPropagationSpeed = (CFloat) CR2WTypeManager.Create("Float", "electroshockPropagationSpeed", cr2w, this);
				}
				return _electroshockPropagationSpeed;
			}
			set
			{
				if (_electroshockPropagationSpeed == value)
				{
					return;
				}
				_electroshockPropagationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("revealPropagationSpeed")] 
		public CFloat RevealPropagationSpeed
		{
			get
			{
				if (_revealPropagationSpeed == null)
				{
					_revealPropagationSpeed = (CFloat) CR2WTypeManager.Create("Float", "revealPropagationSpeed", cr2w, this);
				}
				return _revealPropagationSpeed;
			}
			set
			{
				if (_revealPropagationSpeed == value)
				{
					return;
				}
				_revealPropagationSpeed = value;
				PropertySet(this);
			}
		}

		public audioShockwaveGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
