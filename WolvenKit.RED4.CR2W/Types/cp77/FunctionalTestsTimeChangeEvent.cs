using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsTimeChangeEvent : redEvent
	{
		private CUInt32 _listenerId;

		[Ordinal(0)] 
		[RED("listenerId")] 
		public CUInt32 ListenerId
		{
			get
			{
				if (_listenerId == null)
				{
					_listenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "listenerId", cr2w, this);
				}
				return _listenerId;
			}
			set
			{
				if (_listenerId == value)
				{
					return;
				}
				_listenerId = value;
				PropertySet(this);
			}
		}

		public FunctionalTestsTimeChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
