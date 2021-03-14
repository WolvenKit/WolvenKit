using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCHitSourcePrereq : gameIScriptablePrereq
	{
		private CEnum<EAIHitSource> _hitSource;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("hitSource")] 
		public CEnum<EAIHitSource> HitSource
		{
			get
			{
				if (_hitSource == null)
				{
					_hitSource = (CEnum<EAIHitSource>) CR2WTypeManager.Create("EAIHitSource", "hitSource", cr2w, this);
				}
				return _hitSource;
			}
			set
			{
				if (_hitSource == value)
				{
					return;
				}
				_hitSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public NPCHitSourcePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
