using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualVoiceGrunt : CVariable
	{
		private CName _regularGrunt;
		private CName _stealthGrunt;

		[Ordinal(0)] 
		[RED("regularGrunt")] 
		public CName RegularGrunt
		{
			get
			{
				if (_regularGrunt == null)
				{
					_regularGrunt = (CName) CR2WTypeManager.Create("CName", "regularGrunt", cr2w, this);
				}
				return _regularGrunt;
			}
			set
			{
				if (_regularGrunt == value)
				{
					return;
				}
				_regularGrunt = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stealthGrunt")] 
		public CName StealthGrunt
		{
			get
			{
				if (_stealthGrunt == null)
				{
					_stealthGrunt = (CName) CR2WTypeManager.Create("CName", "stealthGrunt", cr2w, this);
				}
				return _stealthGrunt;
			}
			set
			{
				if (_stealthGrunt == value)
				{
					return;
				}
				_stealthGrunt = value;
				PropertySet(this);
			}
		}

		public audioContextualVoiceGrunt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
