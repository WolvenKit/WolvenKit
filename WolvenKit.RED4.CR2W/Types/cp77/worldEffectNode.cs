using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEffectNode : worldNode
	{
		private raRef<worldEffect> _effect;
		private CFloat _streamingDistanceOverride;

		[Ordinal(4)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "effect", cr2w, this);
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

		[Ordinal(5)] 
		[RED("streamingDistanceOverride")] 
		public CFloat StreamingDistanceOverride
		{
			get
			{
				if (_streamingDistanceOverride == null)
				{
					_streamingDistanceOverride = (CFloat) CR2WTypeManager.Create("Float", "streamingDistanceOverride", cr2w, this);
				}
				return _streamingDistanceOverride;
			}
			set
			{
				if (_streamingDistanceOverride == value)
				{
					return;
				}
				_streamingDistanceOverride = value;
				PropertySet(this);
			}
		}

		public worldEffectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
