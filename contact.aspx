<%@ Page Title="" Language="C#" MasterPageFile="~/clientMasterPage.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- //mian-content-->
	    <!-- /Contact-->
    <section class="banner-bottom py-lg-5 py-md-5 py-3">
        <div class="container">
            <div class="inner-sec py-lg-5 py-3">
               
                <h2 class="tittle text-center mb-md-5 mb-4">Get In Touch</h2>
                <div class="address row">

                    <div class="col-lg-4 address-grid">
                        <div class="row address-info">
                            <div class="col-md-3 address-left text-center">
                                <span class="fa fa-map"></span>
                            </div>
                            <div class="col-md-9 address-right text-left">
                                <h6>Address</h6>
                                <p> New York City,USA

                                </p>
                            </div>
                        </div>

                    </div>
                    <div class="col-lg-4 address-grid">
                        <div class="row address-info">
                            <div class="col-md-3 address-left text-center">
                                <span class="fa fa-envelope"></span>
                            </div>
                            <div class="col-md-9 address-right text-left">
                                <h6>Email</h6>
                                <p>Email :
                                    <a href="mailto:example@email.com"> mail@example.com</a>

                                </p>
                            </div>

                        </div>
                    </div>
                    <div class="col-lg-4 address-grid">
                        <div class="row address-info">
                            <div class="col-md-3 address-left text-center">
                                <span class="fa fa-mobile"></span>
                            </div>
                            <div class="col-md-9 address-right text-left">
                                <h6>Phone</h6>
                                <p>+1 444 555 6789</p>

                            </div>

                        </div>
                    </div>
                </div>
                <div class="contact_grid_right">
                    <form action="#" method="post">
                        <div class="row contact_left_grid">
                            <div class="col-md-6 con-left">
                                <div class="form-group">
                                    <label class="my-2">Name</label>
                                    <input class="form-control" type="text" name="Name" placeholder="" required="">
                                </div>
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control" type="email" name="Email" placeholder="" required="">
                                </div>
                                <div class="form-group">
                                    <label class="my-2">Subject</label>
                                    <input class="form-control" type="text" name="Subject" placeholder="" required="">
                                </div>
                            </div>
                            <div class="col-md-6 con-right">
                                <div class="form-group">
                                    <label>Message</label>
                                    <textarea id="textarea" placeholder="" required=""></textarea>
                                </div>
                                <button class="form-control" type="submit">Submit</button>

                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>
    <!-- //Contact -->
    <div class="contact-map">
		<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d387193.30591910525!2d-74.25986432970718!3d40.697149422113014!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew+York%2C+NY%2C+USA!5e0!3m2!1sen!2sin!4v1531941005301" class="map" style="border:0" allowfullscreen=""></iframe>
</div>
<!--/newsletter-->

</asp:Content>

