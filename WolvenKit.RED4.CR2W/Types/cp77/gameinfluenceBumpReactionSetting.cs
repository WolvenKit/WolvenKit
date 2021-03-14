using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpReactionSetting : ISerializable
	{
		private CEnum<gameinteractionsBumpIntensity> _reaction;
		private CFloat _maxVelocity;

		[Ordinal(0)] 
		[RED("reaction")] 
		public CEnum<gameinteractionsBumpIntensity> Reaction
		{
			get
			{
				if (_reaction == null)
				{
					_reaction = (CEnum<gameinteractionsBumpIntensity>) CR2WTypeManager.Create("gameinteractionsBumpIntensity", "reaction", cr2w, this);
				}
				return _reaction;
			}
			set
			{
				if (_reaction == value)
				{
					return;
				}
				_reaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxVelocity")] 
		public CFloat MaxVelocity
		{
			get
			{
				if (_maxVelocity == null)
				{
					_maxVelocity = (CFloat) CR2WTypeManager.Create("Float", "maxVelocity", cr2w, this);
				}
				return _maxVelocity;
			}
			set
			{
				if (_maxVelocity == value)
				{
					return;
				}
				_maxVelocity = value;
				PropertySet(this);
			}
		}

		public gameinfluenceBumpReactionSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
