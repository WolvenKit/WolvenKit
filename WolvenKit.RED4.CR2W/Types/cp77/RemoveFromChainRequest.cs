using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveFromChainRequest : gameScriptableSystemRequest
	{
		private entEntityID _requestSource;

		[Ordinal(0)] 
		[RED("requestSource")] 
		public entEntityID RequestSource
		{
			get
			{
				if (_requestSource == null)
				{
					_requestSource = (entEntityID) CR2WTypeManager.Create("entEntityID", "requestSource", cr2w, this);
				}
				return _requestSource;
			}
			set
			{
				if (_requestSource == value)
				{
					return;
				}
				_requestSource = value;
				PropertySet(this);
			}
		}

		public RemoveFromChainRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
