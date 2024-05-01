import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss'],
})
export class CheckoutComponent {
  constructor(private fb: FormBuilder) {}

  checkoutForm = this.fb.group({
    addressFrom: this.fb.group({
      firstName: ['', Validators.required],
      lasName: ['', Validators.required],
      street: ['', Validators.required],
      city: ['', Validators.required],
      state: ['', Validators.required],
      zipcode: ['', Validators.required],
    }),
    deliveryForm: this.fb.group({
      deliveryMethod: ['', Validators.required],
    }),
    paymanetForm: this.fb.group({
      nameOnCard: ['', Validators.required],
    }),
  });
}
