using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimationSetup : CVariable
	{
		private animAnimSetCollection _cinematics;
		private animAnimSetCollection _gameplay;
		private animAnimSetCollection _finalAnimSetCollection;

		[Ordinal(0)] 
		[RED("cinematics")] 
		public animAnimSetCollection Cinematics
		{
			get
			{
				if (_cinematics == null)
				{
					_cinematics = (animAnimSetCollection) CR2WTypeManager.Create("animAnimSetCollection", "cinematics", cr2w, this);
				}
				return _cinematics;
			}
			set
			{
				if (_cinematics == value)
				{
					return;
				}
				_cinematics = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gameplay")] 
		public animAnimSetCollection Gameplay
		{
			get
			{
				if (_gameplay == null)
				{
					_gameplay = (animAnimSetCollection) CR2WTypeManager.Create("animAnimSetCollection", "gameplay", cr2w, this);
				}
				return _gameplay;
			}
			set
			{
				if (_gameplay == value)
				{
					return;
				}
				_gameplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("finalAnimSetCollection")] 
		public animAnimSetCollection FinalAnimSetCollection
		{
			get
			{
				if (_finalAnimSetCollection == null)
				{
					_finalAnimSetCollection = (animAnimSetCollection) CR2WTypeManager.Create("animAnimSetCollection", "finalAnimSetCollection", cr2w, this);
				}
				return _finalAnimSetCollection;
			}
			set
			{
				if (_finalAnimSetCollection == value)
				{
					return;
				}
				_finalAnimSetCollection = value;
				PropertySet(this);
			}
		}

		public animAnimationSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
