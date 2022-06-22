using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.SRP
{
  public class OrderBestService
  {
    private NotificationManager _notificationManager;
    private OrderRepository _orderRepository;
    private ShippmentManager _shipmentManager;
    private OrderNumberManager _orderNumberManager;
    private InvoiceManager _invoiceManager;

    public OrderBestService(NotificationManager notificationManager, OrderRepository orderRepository, ShippmentManager shipmentManager, OrderNumberManager orderNumberManager, InvoiceManager invoiceManager)
    {
      _notificationManager = notificationManager;
      _orderRepository = orderRepository;
      _shipmentManager = shipmentManager;
      _orderNumberManager = orderNumberManager;
      _invoiceManager = invoiceManager;
    }

    public void SubmitOrder(Cart cart, string customerNumber)
    {
      _notificationManager.notify();
      _orderNumberManager.GenerateCode();
    }
  }
}
