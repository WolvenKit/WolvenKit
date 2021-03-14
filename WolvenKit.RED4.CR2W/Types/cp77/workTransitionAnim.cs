using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workTransitionAnim : CVariable
	{
		private CName _fromIdle;
		private CName _toIdle;
		private CName _transitionAnim;

		[Ordinal(0)] 
		[RED("fromIdle")] 
		public CName FromIdle
		{
			get
			{
				if (_fromIdle == null)
				{
					_fromIdle = (CName) CR2WTypeManager.Create("CName", "fromIdle", cr2w, this);
				}
				return _fromIdle;
			}
			set
			{
				if (_fromIdle == value)
				{
					return;
				}
				_fromIdle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("toIdle")] 
		public CName ToIdle
		{
			get
			{
				if (_toIdle == null)
				{
					_toIdle = (CName) CR2WTypeManager.Create("CName", "toIdle", cr2w, this);
				}
				return _toIdle;
			}
			set
			{
				if (_toIdle == value)
				{
					return;
				}
				_toIdle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transitionAnim")] 
		public CName TransitionAnim
		{
			get
			{
				if (_transitionAnim == null)
				{
					_transitionAnim = (CName) CR2WTypeManager.Create("CName", "transitionAnim", cr2w, this);
				}
				return _transitionAnim;
			}
			set
			{
				if (_transitionAnim == value)
				{
					return;
				}
				_transitionAnim = value;
				PropertySet(this);
			}
		}

		public workTransitionAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
