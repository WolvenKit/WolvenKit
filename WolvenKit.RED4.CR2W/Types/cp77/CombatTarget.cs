using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatTarget : CVariable
	{
		private wCHandle<ScriptedPuppet> _puppet;
		private CBool _hasTime;
		private CFloat _highlightTime;

		[Ordinal(0)] 
		[RED("puppet")] 
		public wCHandle<ScriptedPuppet> Puppet
		{
			get
			{
				if (_puppet == null)
				{
					_puppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "puppet", cr2w, this);
				}
				return _puppet;
			}
			set
			{
				if (_puppet == value)
				{
					return;
				}
				_puppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasTime")] 
		public CBool HasTime
		{
			get
			{
				if (_hasTime == null)
				{
					_hasTime = (CBool) CR2WTypeManager.Create("Bool", "hasTime", cr2w, this);
				}
				return _hasTime;
			}
			set
			{
				if (_hasTime == value)
				{
					return;
				}
				_hasTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("highlightTime")] 
		public CFloat HighlightTime
		{
			get
			{
				if (_highlightTime == null)
				{
					_highlightTime = (CFloat) CR2WTypeManager.Create("Float", "highlightTime", cr2w, this);
				}
				return _highlightTime;
			}
			set
			{
				if (_highlightTime == value)
				{
					return;
				}
				_highlightTime = value;
				PropertySet(this);
			}
		}

		public CombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
