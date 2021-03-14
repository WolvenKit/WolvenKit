using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyNPCMetadata : audioAudioMetadata
	{
		private audioMeleeSound _fastHeavy;
		private audioMeleeSound _fastMedium;
		private audioMeleeSound _fastLight;
		private audioMeleeSound _normalHeavy;
		private audioMeleeSound _normalMedium;
		private audioMeleeSound _normalLight;
		private audioMeleeSound _slowHeavy;
		private audioMeleeSound _slowMedium;
		private audioMeleeSound _slowLight;
		private audioMeleeSound _walk;
		private audioMeleeSound _run;

		[Ordinal(1)] 
		[RED("fastHeavy")] 
		public audioMeleeSound FastHeavy
		{
			get
			{
				if (_fastHeavy == null)
				{
					_fastHeavy = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "fastHeavy", cr2w, this);
				}
				return _fastHeavy;
			}
			set
			{
				if (_fastHeavy == value)
				{
					return;
				}
				_fastHeavy = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fastMedium")] 
		public audioMeleeSound FastMedium
		{
			get
			{
				if (_fastMedium == null)
				{
					_fastMedium = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "fastMedium", cr2w, this);
				}
				return _fastMedium;
			}
			set
			{
				if (_fastMedium == value)
				{
					return;
				}
				_fastMedium = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fastLight")] 
		public audioMeleeSound FastLight
		{
			get
			{
				if (_fastLight == null)
				{
					_fastLight = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "fastLight", cr2w, this);
				}
				return _fastLight;
			}
			set
			{
				if (_fastLight == value)
				{
					return;
				}
				_fastLight = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("normalHeavy")] 
		public audioMeleeSound NormalHeavy
		{
			get
			{
				if (_normalHeavy == null)
				{
					_normalHeavy = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "normalHeavy", cr2w, this);
				}
				return _normalHeavy;
			}
			set
			{
				if (_normalHeavy == value)
				{
					return;
				}
				_normalHeavy = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("normalMedium")] 
		public audioMeleeSound NormalMedium
		{
			get
			{
				if (_normalMedium == null)
				{
					_normalMedium = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "normalMedium", cr2w, this);
				}
				return _normalMedium;
			}
			set
			{
				if (_normalMedium == value)
				{
					return;
				}
				_normalMedium = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("normalLight")] 
		public audioMeleeSound NormalLight
		{
			get
			{
				if (_normalLight == null)
				{
					_normalLight = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "normalLight", cr2w, this);
				}
				return _normalLight;
			}
			set
			{
				if (_normalLight == value)
				{
					return;
				}
				_normalLight = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("slowHeavy")] 
		public audioMeleeSound SlowHeavy
		{
			get
			{
				if (_slowHeavy == null)
				{
					_slowHeavy = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "slowHeavy", cr2w, this);
				}
				return _slowHeavy;
			}
			set
			{
				if (_slowHeavy == value)
				{
					return;
				}
				_slowHeavy = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("slowMedium")] 
		public audioMeleeSound SlowMedium
		{
			get
			{
				if (_slowMedium == null)
				{
					_slowMedium = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "slowMedium", cr2w, this);
				}
				return _slowMedium;
			}
			set
			{
				if (_slowMedium == value)
				{
					return;
				}
				_slowMedium = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("slowLight")] 
		public audioMeleeSound SlowLight
		{
			get
			{
				if (_slowLight == null)
				{
					_slowLight = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "slowLight", cr2w, this);
				}
				return _slowLight;
			}
			set
			{
				if (_slowLight == value)
				{
					return;
				}
				_slowLight = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("walk")] 
		public audioMeleeSound Walk
		{
			get
			{
				if (_walk == null)
				{
					_walk = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "walk", cr2w, this);
				}
				return _walk;
			}
			set
			{
				if (_walk == value)
				{
					return;
				}
				_walk = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("run")] 
		public audioMeleeSound Run
		{
			get
			{
				if (_run == null)
				{
					_run = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "run", cr2w, this);
				}
				return _run;
			}
			set
			{
				if (_run == value)
				{
					return;
				}
				_run = value;
				PropertySet(this);
			}
		}

		public audioFoleyNPCMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
