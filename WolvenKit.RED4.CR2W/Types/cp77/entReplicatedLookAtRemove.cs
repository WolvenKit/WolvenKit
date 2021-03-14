using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedLookAtRemove : entReplicatedLookAtData
	{
		private animLookAtRef _ref;
		private CFloat _hasOutTransition;
		private CFloat _outTransitionSpeed;

		[Ordinal(1)] 
		[RED("ref")] 
		public animLookAtRef Ref
		{
			get
			{
				if (_ref == null)
				{
					_ref = (animLookAtRef) CR2WTypeManager.Create("animLookAtRef", "ref", cr2w, this);
				}
				return _ref;
			}
			set
			{
				if (_ref == value)
				{
					return;
				}
				_ref = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasOutTransition")] 
		public CFloat HasOutTransition
		{
			get
			{
				if (_hasOutTransition == null)
				{
					_hasOutTransition = (CFloat) CR2WTypeManager.Create("Float", "hasOutTransition", cr2w, this);
				}
				return _hasOutTransition;
			}
			set
			{
				if (_hasOutTransition == value)
				{
					return;
				}
				_hasOutTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get
			{
				if (_outTransitionSpeed == null)
				{
					_outTransitionSpeed = (CFloat) CR2WTypeManager.Create("Float", "outTransitionSpeed", cr2w, this);
				}
				return _outTransitionSpeed;
			}
			set
			{
				if (_outTransitionSpeed == value)
				{
					return;
				}
				_outTransitionSpeed = value;
				PropertySet(this);
			}
		}

		public entReplicatedLookAtRemove(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
