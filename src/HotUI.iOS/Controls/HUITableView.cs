using System;
using Foundation;
using UIKit;

namespace Comet.iOS.Controls
{
    public class HUITableView : UITableView
    {
        private HUITableViewSource _delegate;
        
        public HUITableView()
        {
            _delegate = new HUITableViewSource();
            WeakDataSource = _delegate;
            WeakDelegate = _delegate;
        }

        public IListView ListView
        {
            get => _delegate.ListView;
            set
            {
                _delegate.ListView = value;

                // If we have items in the list, we can check to see if there are frame constraints on the root view.  If so,
                // we can use those as our cell height.
                if (value?.Sections() > 0 && value?.Rows(0) > 0)
                {
                    var v = value.ViewFor(0,0);                    
                    if (v.FrameConstraints?.Height != null)
                        RowHeight = (float)v.FrameConstraints.Height;
                    else
                        RowHeight = -1;
                }
                else
                {
                    RowHeight = -1;
                }


                ReloadData();
            }
        }

        public bool UnevenRows
        {
            get => _delegate.UnevenRows;
            set => _delegate.UnevenRows = value;
        }
    }
}