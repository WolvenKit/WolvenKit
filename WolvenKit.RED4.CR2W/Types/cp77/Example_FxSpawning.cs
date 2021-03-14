using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Example_FxSpawning : gameScriptableComponent
	{
		private gameFxResource _effect;
		private gameFxResource _effectBeam;

		[Ordinal(5)] 
		[RED("effect")] 
		public gameFxResource Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("effectBeam")] 
		public gameFxResource EffectBeam
		{
			get
			{
				if (_effectBeam == null)
				{
					_effectBeam = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "effectBeam", cr2w, this);
				}
				return _effectBeam;
			}
			set
			{
				if (_effectBeam == value)
				{
					return;
				}
				_effectBeam = value;
				PropertySet(this);
			}
		}

		public Example_FxSpawning(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
